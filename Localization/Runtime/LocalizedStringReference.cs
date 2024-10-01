using System;
using System.Globalization;
using JetBrains.Annotations;
using Radish.Logging;
using SmartFormat;
using SmartFormat.Core.Extensions;
using SmartFormat.Core.Output;
using SmartFormat.ZString;
using TMPro;
using UnityEngine;
using ILogger = Radish.Logging.ILogger;

namespace Radish.Localization
{
    public class LocalizedStringReference : ScriptableObject
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        
        private class TMPOutput : IOutput
        {
            public TMP_Text Text { get; set; }

            private static char[] s_StaticCharBuf = new char[256];
            
            public void Write(string text, IFormattingInfo formattingInfo = null)
            {
                #if UNITY_EDITOR
                Logger.Warn("Using slow write path :(");
                #endif
                Text.SetText(text);
            }

            public void Write(ReadOnlySpan<char> text, IFormattingInfo formattingInfo = null)
            {
                Array.Clear(s_StaticCharBuf, 0, s_StaticCharBuf.Length);
                if (s_StaticCharBuf.Length < text.Length)
                {
                    Array.Resize(ref s_StaticCharBuf, text.Length);
                }
                
                text.CopyTo(s_StaticCharBuf);
                Text.SetText(s_StaticCharBuf);
            }

            public void Write(ZStringBuilder stringBuilder, IFormattingInfo formattingInfo = null)
            {
                var seg = stringBuilder.AsArraySegment();
                Text.SetCharArray(seg.Array, seg.Offset, seg.Count);
            }
        }
        
        [SerializeField] private LocalizedStringTable m_Table;
        [SerializeField] private string m_Key;

        private static readonly TMPOutput s_TMPOutput = new();

        #if UNITY_EDITOR
        internal static LocalizedStringReference Create(LocalizedStringTable table, string key)
        {
            var r = CreateInstance<LocalizedStringReference>();
            r.m_Key = key;
            r.m_Table = table;
            return r;
        }
        #endif

        [PublicAPI]
        public string text => !m_Table.TryGetString(m_Key, CultureInfo.CurrentCulture, out var f) 
            ? m_Key : f;

        public void WriteTo<T>(TMP_Text dest, T dataSource)
        {
            Debug.Assert(m_Table);
            Debug.Assert(m_Key != null);
            
            if (!m_Table.TryGetString(m_Key, CultureInfo.CurrentCulture, out var f))
            {
                dest.SetText(m_Key);
                return;
            }

            //TODO: I don't understand how IOutput works, just waste memory for now
            //s_TMPOutput.Text = dest;
            //Smart.Default.FormatInto(s_TMPOutput, f, dataSource);
            dest.SetText(Smart.Format(f, dataSource));
        }
        
        public void WriteTo(TMP_Text dest)
        {
            Debug.Assert(m_Table);
            Debug.Assert(m_Key != null);
            
            if (!m_Table.TryGetString(m_Key, CultureInfo.CurrentCulture, out var f))
            {
                dest.SetText(m_Key);
                return;
            }

            dest.SetText(f);
        }

        public override string ToString()
        {
            return m_Key;
        }
    }
}