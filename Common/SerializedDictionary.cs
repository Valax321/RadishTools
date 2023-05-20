using System;
using System.Collections.Generic;
using UnityEngine;

namespace OrbHall
{
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