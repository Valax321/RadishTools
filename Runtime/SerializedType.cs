using System;
using UnityEngine;

namespace Radish
{
    [Serializable]
    public sealed class SerializedType : ISerializationCallbackReceiver, IEquatable<SerializedType>
    {
        [SerializeField] private string m_TypeName;
        
        public Type type { get; set; }

        public void OnBeforeSerialize()
        {
            m_TypeName = type?.AssemblyQualifiedName ?? string.Empty;
        }

        public void OnAfterDeserialize()
        {
            if (!string.IsNullOrEmpty(m_TypeName))
                type = Type.GetType(m_TypeName);
        }

        public bool Equals(SerializedType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return type == other.type;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is SerializedType other && Equals(other);
        }

        public override int GetHashCode()
        {
            return (type != null ? type.GetHashCode() : 0);
        }
    }
}