using System;
#if ODIN_INSPECTOR
using Sirenix.Utilities.Editor;
#endif
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace OrbHall
{
    internal abstract class SoftObjectPropertyDrawerBase : PropertyDrawer
    {
        protected abstract string guidPropertyName { get; }
        protected abstract Type fieldType { get; }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            try
            {
                var guidProperty = property.FindPropertyRelative(guidPropertyName);

                Object asset = null;
                if (!string.IsNullOrEmpty(guidProperty.stringValue))
                {
                    var path = AssetDatabase.GUIDToAssetPath(guidProperty.stringValue);
                    if (!string.IsNullOrEmpty(path))
                    {
                        asset = AssetDatabase.LoadAssetAtPath(path, fieldType);
                    }
                }
                
                EditorGUI.BeginChangeCheck();
#if ODIN_INSPECTOR
                asset = SirenixEditorFields.UnityObjectField(position, label, asset, fieldType, false);
#else
                asset = EditorGUI.ObjectField(position, label, asset, fieldType, false);
#endif
                if (EditorGUI.EndChangeCheck())
                {
                    if (!asset)
                        guidProperty.stringValue = string.Empty;
                    else
                    {
                        var path = AssetDatabase.GetAssetPath(asset);
                        guidProperty.stringValue = AssetDatabase.AssetPathToGUID(path);
                    }
                }
            }
            finally
            {
                EditorGUI.EndProperty();
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.ObjectReference, label);
        }
    }
}