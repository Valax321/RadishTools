using System;
using UnityEngine;

namespace Radish
{
    [Serializable]
    public sealed class SoftSceneReference : ISoftObjectReference, IEquatable<SoftSceneReference>
    {
        [SerializeField] private string m_Guid;

        public string guid => m_Guid;

        public bool isValid => !string.IsNullOrEmpty(m_Guid);

        public override string ToString()
        {
#if !UNITY_EDITOR
            return string.Format("{0} (Scene)", m_Guid);
#else
            return string.Format("{0} (Scene)", UnityEditor.AssetDatabase.GUIDToAssetPath(m_Guid));
#endif
        }

        public static bool operator ==(SoftSceneReference lhs, SoftSceneReference rhs)
        {
            return lhs?.Equals(rhs) ?? false;
        }
        
        public static bool operator !=(SoftSceneReference lhs, SoftSceneReference rhs)
        {
            return !(lhs == rhs);
        }

        public override int GetHashCode()
        {
            return (m_Guid != null ? m_Guid.GetHashCode() : 0);
        }

        public bool Equals(SoftSceneReference other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return m_Guid == other.m_Guid;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is SoftSceneReference other && Equals(other);
        }
    }
}