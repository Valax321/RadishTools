using System;
using JetBrains.Annotations;
using TMPro;

namespace Radish.Localization
{
    [PublicAPI]
    public static class TestMeshProExtensions
    {
        public static void SetText(this TMP_Text text, LocalizedStringReference s)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));

            if (s is null)
            {
                text.SetText("##NULL STRINGREF##");
                return;
            }
            
            s.WriteTo(text);
        }
        
        public static void SetText<T>(this TMP_Text text, LocalizedStringReference s, T formatDataSource)
        {
            if (s is null)
            {
                text.SetText("##NULL STRINGREF##");
                return;
            }
            
            s.WriteTo(text, formatDataSource);
        }
    }
}