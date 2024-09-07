using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish.Localization
{
    public class LocalizedStringTable : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField] private SerializedCultureInfo m_NativeCulture = new();
        [SerializeField] private List<string> m_Keys = new();
        [SerializeField] private List<CultureStringTable> m_StringTables = new();

        private readonly Dictionary<int, CultureStringTable> m_StringTableLookup = new();

#if UNITY_EDITOR
        internal static LocalizedStringTable Build(
            Func<CultureInfo> getNativeCulture,
            Func<IReadOnlyList<Tuple<CultureInfo, string, string>>> getStrings)
        {
            var table = CreateInstance<LocalizedStringTable>();
            table.m_NativeCulture = new SerializedCultureInfo(getNativeCulture());
            var strings = getStrings();
            var cultures = strings.Select(x => x.Item1)
                .Distinct(new CultureInfoComparer())
                .ToDictionary(k => k, k => new CultureStringTable(k));

            table.m_StringTables.AddRange(cultures.Values);
            table.m_Keys.AddRange(strings.Select(x => x.Item2).Distinct());
            foreach (var (culture, key, text) in strings)
            {
                var t = cultures[culture];
                t.strings.Add(table.m_Keys.IndexOf(key), text);
            }

            return table;
        }

        private class CultureInfoComparer : IEqualityComparer<CultureInfo>
        {
            public bool Equals(CultureInfo x, CultureInfo y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (x is null) return false;
                if (y is null) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.LCID == y.LCID;
            }

            public int GetHashCode(CultureInfo obj)
            {
                return obj.LCID;
            }
        }
#endif

        public IReadOnlyList<string> keys => m_Keys;
        public CultureInfo defaultCulture => m_NativeCulture.value;

        [PublicAPI]
        public bool TryGetString(string key, CultureInfo culture, out string localizedString)
        {
            if (culture is null)
                throw new ArgumentNullException(nameof(culture));

            if (string.IsNullOrEmpty(key))
            {
                localizedString = "##NO STRINGREF##";
                return false;
            }

            var c = culture;
            while (!Equals(c, CultureInfo.InvariantCulture))
            {
                c = c.Parent;
            }

            if (Equals(c, CultureInfo.InvariantCulture))
                c = m_NativeCulture.value;

            localizedString = m_StringTableLookup[c.LCID]
                .strings[m_Keys.IndexOf(key)];
            return true;
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            m_StringTableLookup.Clear();
            foreach (var table in m_StringTables)
            {
                m_StringTableLookup.Add(table.culture.LCID, table);
            }
        }
    }
}