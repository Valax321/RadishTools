using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Radish.Localization
{
    [CustomPropertyDrawer(typeof(SerializedCultureInfo))]
    public class SerializedCultureInfoDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            var lcid = property.FindPropertyRelative("m_LCID");
            var cultures = SerializedCultureInfo.GetCultures().ToList();
            
            EditorGUI.BeginChangeCheck();

            var value = EditorGUI.Popup(position, label, cultures.FindIndex(x => x.Value == lcid.intValue),
                cultures.Select(x => new GUIContent(x.Text)).ToArray());
            
            if (EditorGUI.EndChangeCheck())
            {
                lcid.intValue = cultures[value].Value;
            }
            EditorGUI.EndProperty();
        }
    }
}