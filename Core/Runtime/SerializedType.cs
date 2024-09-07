using System;
using System.IO;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    /// <summary>
    /// A Unity-serializable wrapper for .NET's <see cref="Type"/>.
    /// </summary>
    [Serializable]
    [PublicAPI]
    public sealed class SerializedType : ISerializationCallbackReceiver, IEquatable<SerializedType>
    {
        [SerializeField] private string m_TypeName;
        
        /// <summary>
        /// The actual type resolved. Can be null if no type was assigned, or there was an error resolving the type.
        /// </summary>
        [CanBeNull] public Type type { get; set; }

        /// <summary>
        /// True if the type was successfully resolved.
        /// If there was an error resolving the type that was serialized, this will be false.
        /// </summary>
        public bool isValid { get; private set; } = true;

        public void OnBeforeSerialize()
        {
            m_TypeName = type?.AssemblyQualifiedName ?? string.Empty;
        }

        public void OnAfterDeserialize()
        {
            try
            {
                if (!string.IsNullOrEmpty(m_TypeName))
                    type = Type.GetType(m_TypeName, throwOnError: true);
            }
            catch (Exception ex)
            {
                isValid = false;
                if (ex is TypeLoadException or FileNotFoundException or FileLoadException or BadImageFormatException)
                {
                    Debug.LogErrorFormat("Failed to resolve type: {0}", ex.Message);
                }
                else
                {
                    throw;
                }
            }
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

        public override string ToString()
        {
            return !string.IsNullOrEmpty(m_TypeName) ? m_TypeName : "<none>";
        }
    }
}