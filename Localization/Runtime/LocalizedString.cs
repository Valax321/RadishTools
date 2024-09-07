using System;
using UnityEngine;

namespace Radish.Localization
{
    [Serializable]
    public sealed class LocalizedString
    {
        [SerializeField] private string m_Text;

        public override string ToString()
        {
            return m_Text;
        }
    }
}