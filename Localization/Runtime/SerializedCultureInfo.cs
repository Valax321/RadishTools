using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Radish.Localization
{
    [Serializable, InlineProperty]
    public class SerializedCultureInfo : ISerializationCallbackReceiver
    {
        [HideLabel, ValueDropdown(nameof(GetCultures))]
        [SerializeField] private int m_LCID;
        
        public CultureInfo value { get; private set; }

        public SerializedCultureInfo()
        {
            value = CultureInfo.InvariantCulture;
            m_LCID = value.LCID;
        }

        public SerializedCultureInfo(CultureInfo culture)
        {
            value = culture;
            m_LCID = value.LCID;
        }
        
        public static IEnumerable<ValueDropdownItem<int>> GetCultures()
        {
            return CultureInfo.GetCultures(CultureTypes.AllCultures)
                .Select(c => new ValueDropdownItem<int>($"{c.DisplayName} ({c.Name})", c.LCID));
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            value = CultureInfo.GetCultureInfo(m_LCID);
        }
    }
}