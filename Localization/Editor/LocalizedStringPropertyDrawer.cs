using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEditor;
using UnityEngine;

namespace Radish.Localization
{
    public class LocalizedStringPropertyDrawer : OdinValueDrawer<LocalizedString>
    {
        protected override void DrawPropertyLayout(GUIContent label)
        {
            var rect = EditorGUILayout.GetControlRect();
            if (label != null)
                rect = EditorGUI.PrefixLabel(rect, label);

            var textProp = ValueEntry.Property.Children.Get("m_Text");
            var text = textProp.ValueEntry.WeakSmartValue as string;

            text = SirenixEditorFields.TextField(rect, text);
            textProp.ValueEntry.WeakSmartValue = text;
        }
    }
}