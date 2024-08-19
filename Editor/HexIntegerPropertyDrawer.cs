#if ODIN_INSPECTOR
using System;
using System.Globalization;
using JetBrains.Annotations;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace Radish
{
    [UsedImplicitly]
    internal class HexIntegerPropertyDrawer : OdinAttributeDrawer<HexIntegerAttribute>
    {
        protected override void DrawPropertyLayout(GUIContent label)
        {
            var rect = EditorGUILayout.GetControlRect();
            if (label != null)
                rect = EditorGUI.PrefixLabel(rect, label);

            var value = Property.ValueEntry.WeakSmartValue;
            switch (value)
            {
                case byte b:
                    DoField(rect, b, x => x.ToString("x2"), x => byte.Parse(x, NumberStyles.HexNumber));
                    break;
                case short s:
                    DoField(rect, s, x => x.ToString("x4"), x => short.Parse(x, NumberStyles.HexNumber));
                    break;
                case int i:
                    DoField(rect, i, x => x.ToString("x8"), x => int.Parse(x, NumberStyles.HexNumber));
                    break;
                case long l:
                    DoField(rect, l, x => x.ToString("x16"), x => long.Parse(x, NumberStyles.HexNumber));
                    break;
                default:
                    EditorGUI.HelpBox(rect, "Type not supported", MessageType.Warning);
                    break;
            }
        }

        private static readonly GUIContent s_HexPrefix = new("0x");

        private void DoField<T>(Rect rect, T value, Func<T, string> stringify, Func<string, T> converter)
        {
            var stringValue = stringify(value);
            //rect = SirenixEditorGUI.PrefixRect(rect, s_HexPrefix, out _);
            var result = EditorGUI.DelayedTextField(rect, stringValue);
            try
            {
                var newValue = converter(result);
                Property.ValueEntry.WeakSmartValue = newValue;
            }
            catch (FormatException) { }
            catch (OverflowException) { }
        }
    }
}
#endif