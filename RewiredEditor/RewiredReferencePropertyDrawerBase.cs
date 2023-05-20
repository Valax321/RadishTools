using System;
using System.Collections.Generic;
using Rewired;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace OrbHall.Rewired
{
    internal abstract class RewiredReferencePropertyDrawerBase : PropertyDrawer
    {
        public class RewiredEntryDropdownItem : AdvancedDropdownItem
        {
            public int rewiredId { get; }
            public string rewiredName { get; }
            
            public RewiredEntryDropdownItem(string name, int id, string rewiredName) : base(name)
            {
                rewiredId = id;
                this.rewiredName = rewiredName;
            }
        }
        
        private class RewiredEntryDropdown : AdvancedDropdown
        {
            private readonly Action<InputManager_Base, AdvancedDropdownItem> m_GetItemsCallback;
            private readonly SerializedProperty m_Prop;

            public RewiredEntryDropdown(Action<InputManager_Base, AdvancedDropdownItem> callback, SerializedProperty prop, AdvancedDropdownState state) : base(state)
            {
                m_GetItemsCallback = callback;
                m_Prop = prop;
            }

            protected override AdvancedDropdownItem BuildRoot()
            {
                var root = new AdvancedDropdownItem("Input Managers");
                
                foreach (var p in AssetDatabase.FindAssets("t:GameObject"))
                {
                    var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(p));
                    if (prefab.TryGetComponent(out InputManager_Base inputManager))
                    {
                        var item = new AdvancedDropdownItem(prefab.name);
                        m_GetItemsCallback.Invoke(inputManager, item);
                        root.AddChild(item);
                    }
                }

                return root;
            }

            protected override void ItemSelected(AdvancedDropdownItem item)
            {
                if (item is RewiredEntryDropdownItem rewiredEntry)
                {
                    m_Prop.FindPropertyRelative("m_Id").intValue = rewiredEntry.rewiredId;
                    m_Prop.FindPropertyRelative("m_Name").stringValue = rewiredEntry.rewiredName;
                    m_Prop.serializedObject.ApplyModifiedProperties();
                }
            }
        }

        private static Dictionary<string, AdvancedDropdownState> s_State = new();

        protected abstract void GetItems(InputManager_Base inputManager, AdvancedDropdownItem parent);
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            try
            {
                var dropdownState = s_State.GetOrAddValue(property.propertyPath, () => new AdvancedDropdownState());
                var selectedName = property.FindPropertyRelative("m_Name").stringValue;
                
                var indentPos = EditorGUI.PrefixLabel(position, label);
                if (EditorGUI.DropdownButton(indentPos, new GUIContent(!string.IsNullOrEmpty(selectedName) ? selectedName : "None"), FocusType.Keyboard))
                {
                    var dropdown = new RewiredEntryDropdown(GetItems, property, dropdownState);
                    dropdown.Show(indentPos);
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