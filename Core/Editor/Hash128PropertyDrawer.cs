#if ODIN_INSPECTOR
using JetBrains.Annotations;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace Radish
{
    [UsedImplicitly]
    internal class Hash128PropertyDrawer : OdinValueDrawer<Hash128>
    {
        protected override void DrawPropertyLayout(GUIContent label)
        {
            var rect = EditorGUILayout.GetControlRect();
            if (label != null)
                rect = EditorGUI.PrefixLabel(rect, label);

            var value = ValueEntry.SmartValue;
            var hashString = EditorGUI.DelayedTextField(rect, value.ToString());
            value = Hash128.Parse(hashString);
            ValueEntry.SmartValue = value;
        }
    }
}
#endif