using System;
using UnityEngine;

namespace Radish
{
    /// <summary>
    /// A unity-serializable wrapper for <see cref="System.Guid"/>.
    /// </summary>
    [Serializable]
    public struct SerializedGuid : ISerializationCallbackReceiver, IEquatable<SerializedGuid>
    {
        public Guid value { get; private set; }

        [HideInInspector]
        [SerializeField] private byte[] m_Data;

        public SerializedGuid(Guid guid)
        {
            value = guid;
            m_Data = null;
        }
        
        public void OnBeforeSerialize()
        {
            m_Data = value.ToByteArray();
        }

        public void OnAfterDeserialize()
        {
            if (m_Data == null)
                return;

            if (m_Data.Length != 16)
                return;
            
            value = new Guid(m_Data);
            m_Data = null;
        }

        public bool Equals(SerializedGuid other)
        {
            return value.Equals(other.value);
        }

        public override bool Equals(object obj)
        {
            return obj is SerializedGuid other && Equals(other);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}