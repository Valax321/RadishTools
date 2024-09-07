using System;
using UnityEditor;
using UnityEngine;

namespace Radish
{
    [CustomPropertyDrawer(typeof(SerializedGuid))]
    internal class SerializedGuidPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            try
            {
                var fieldRect = position.WithWidth(position.width - 62);
                var buttonRect = position.WithWidth(60).WithX(position.x + position.width - 60);
                
                var dataProp = property.FindPropertyRelative("m_Data");
                var guid = GetGuidFromProperty(dataProp);
                var guidString = EditorGUI.DelayedTextField(fieldRect, label, guid.ToString());
                if (Guid.TryParse(guidString, out guid))
                {
                    SetPropertyToGuid(guid, dataProp);
                }

                if (GUI.Button(buttonRect, "Random"))
                {
                    SetPropertyToGuid(Guid.NewGuid(), dataProp);
                }
            }
            finally
            {
                EditorGUI.EndProperty();
            }
        }

        private static Guid GetGuidFromProperty(SerializedProperty prop)
        {
            var data = new byte[16];
            for (var i = 0; i < Mathf.Min(data.Length, prop.arraySize); i++)
            {
                data[i] = (byte)prop.GetArrayElementAtIndex(i).intValue;
            }

            return new Guid(data);
        }

        private static void SetPropertyToGuid(Guid guid, SerializedProperty prop)
        {
            var data = guid.ToByteArray();
            prop.arraySize = data.Length;
            for (var i = 0; i < data.Length; i++)
            {
                var iProp = prop.GetArrayElementAtIndex(i);
                iProp.intValue = data[i];
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(SerializedPropertyType.String, label);
        }
    }
}