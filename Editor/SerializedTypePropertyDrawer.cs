using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Radish
{
    [CustomPropertyDrawer(typeof(SerializedType))]
    internal class SerializedTypePropertyDrawer : PropertyDrawer
    {
        private class SerializedTypeAdvancedDropdown : AdvancedDropdown
        {
            private class TypeItem : AdvancedDropdownItem
            {
                public Type type { get; }
                
                public TypeItem(Type t) : base(t.Name)
                {
                    type = t;
                }
            }
            
            private class NamespaceItem : AdvancedDropdownItem
            {
                private Dictionary<string, AdvancedDropdownItem> m_Items = new();

                public NamespaceItem(string name) : base(name)
                {
                }

                public void AddChild(string[] namespaceRemainder, Type t)
                {
                    if (namespaceRemainder.Length == 0)
                    {
                        AddChild(new TypeItem(t));
                    }
                    else
                    {
                        var ns0 = namespaceRemainder[0];
                        var alreadyAdded = m_Items.ContainsKey(ns0);
                        var ns = m_Items.GetOrAddValue(ns0, (nn) => new NamespaceItem(nn), ns0) as NamespaceItem;
                        if (!alreadyAdded)
                            AddChild(ns);
                        ns?.AddChild(namespaceRemainder[1..], t);
                    }
                }
            }
            
            private readonly Type m_BaseType;
            private readonly SerializedProperty m_Prop;
            
            public SerializedTypeAdvancedDropdown(AdvancedDropdownState state, Type t, SerializedProperty prop) : base(state)
            {
                m_BaseType = t;
                m_Prop = prop;
            }

            protected override AdvancedDropdownItem BuildRoot()
            {
                var root = new AdvancedDropdownItem("Types");
                var dict = new Dictionary<string, NamespaceItem>();

                foreach (var t in TypeCache.GetTypesDerivedFrom(m_BaseType))
                {
                    var ns = t.Namespace;
                    if (ns == null)
                        ns = "<global>";

                    var nsParts = ns.Split('.');
                    if (nsParts.Length == 0)
                    {
                        throw new InvalidOperationException();
                    }

                    var ns0 = nsParts[0];
                    var item = dict.GetOrAddValue(ns0, (nn) => new NamespaceItem(nn), ns0);
                    item.AddChild(nsParts[1..], t);
                }

                foreach (var (_, ns) in dict.OrderBy(x => x.Key))
                {
                    root.AddChild(ns);
                }

                return root;
            }

            protected override void ItemSelected(AdvancedDropdownItem item)
            {
                if (item is TypeItem t)
                {
                    m_Prop.stringValue = t.type.AssemblyQualifiedName;
                    m_Prop.serializedObject.ApplyModifiedProperties();
                }
            }
        }
        
        private static Dictionary<string, AdvancedDropdownState> s_State = new();
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            try
            {
                var typeNameProp = property.FindPropertyRelative("m_TypeName");
                Type t = null;
                if (!string.IsNullOrEmpty(typeNameProp.stringValue))
                {
                    t = Type.GetType(typeNameProp.stringValue);
                }

                position = EditorGUI.PrefixLabel(position, label);
                if (EditorGUI.DropdownButton(position, new GUIContent(t?.FullName ?? "None"), FocusType.Keyboard))
                {
                    var constraint = typeof(Object); // to make things less slow
                    var constraintAttr = fieldInfo?.GetCustomAttribute<SerializedTypeSettingsAttribute>();
                    if (constraintAttr?.constraintType != null)
                        constraint = constraintAttr.constraintType;

                    var dropdownState = s_State.GetOrAddValue(property.propertyPath, () => new AdvancedDropdownState());
                    var dropdown = new SerializedTypeAdvancedDropdown(dropdownState, constraint, typeNameProp);
                    dropdown.Show(position);
                }
            }
            finally
            {
                EditorGUI.EndProperty();
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.Enum, label);
        }
    }
}