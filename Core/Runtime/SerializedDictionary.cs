using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    /// <summary>
    /// A dictionary that supports Unity's serialization system.
    /// The key and value type must also be serializable by Unity.
    /// </summary>
    /// <typeparam name="TKey">The key type.</typeparam>
    /// <typeparam name="TValue">The value type.</typeparam>
    [PublicAPI]
    [Serializable]
    public sealed class SerializedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
    {
        [Serializable]
        private class Entry : IKeyValuePair<TKey, TValue>
        {
            [SerializeField] private TKey m_Key;
            [SerializeField] private TValue m_Value;

            public Entry(TKey key, TValue value)
            {
                m_Key = key;
                m_Value = value;
            }

            public TKey key
            {
                get => m_Key;
                set => m_Key = value;
            }

            public TValue value
            {
                get => m_Value;
                set => m_Value = value;
            }
        }

        [SerializeField] private List<Entry> m_KeyValuePairs = new();

        public void OnBeforeSerialize()
        {
            m_KeyValuePairs.Clear();
            foreach (var (k, v) in this)
            {
                m_KeyValuePairs.Add(new Entry(k, v));
            }
        }

        public void OnAfterDeserialize()
        {
            Clear();

            foreach (var kv in m_KeyValuePairs)
            {
                Add(kv.key, kv.value);
            }
            
            m_KeyValuePairs.Clear();
        }
    }
    
    /// <summary>
    /// A dictionary that supports Unity's serialization system.
    /// The key and value type must also be serializable by Unity.
    /// This version allows the use of a custom type for serialization
    /// that is transformed into the dictionary at load time (to allow custom attributes on the key and value for instance).
    /// </summary>
    /// <typeparam name="TKey">The key type</typeparam>
    /// <typeparam name="TValue">The value type</typeparam>
    /// <typeparam name="TKeyValuePair">The custom key-value pair type.</typeparam>
    [PublicAPI]
    [Serializable]
    public sealed class SerializedDictionary<TKey, TValue, TKeyValuePair> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver 
        where TKeyValuePair : IKeyValuePair<TKey, TValue>, new()
    {
        [SerializeField] private List<TKeyValuePair> m_KeyValuePairs = new();

        public void OnBeforeSerialize()
        {
            m_KeyValuePairs.Clear();
            foreach (var (k, v) in this)
            {
                m_KeyValuePairs.Add(new TKeyValuePair()
                {
                    key = k,
                    value = v
                });
            }
        }

        public void OnAfterDeserialize()
        {
            Clear();

            foreach (var kv in m_KeyValuePairs)
            {
                Add(kv.key, kv.value);
            }
            
            m_KeyValuePairs.Clear();
        }
    }
}