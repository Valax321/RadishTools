using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Radish.Localization
{
    [Serializable]
    public class CultureStringTable
    {
        [SerializeField] private SerializedCultureInfo m_Culture;
        [SerializeField] private SerializedDictionary<int, string> m_Strings = new();

        public CultureInfo culture => m_Culture.value;
        public IDictionary<int, string> strings => m_Strings;

        public CultureStringTable(CultureInfo culture)
        {
            m_Culture = new SerializedCultureInfo(culture);
        }
    }
}