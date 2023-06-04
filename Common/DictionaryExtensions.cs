using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace OrbHall
{
    [PublicAPI]
    public static class DictionaryExtensions
    {
        public static TValue GetOrAddValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
            Func<TValue> valueGenerator)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, valueGenerator());
            }

            return dictionary[key];
        }
    
        public static TValue GetOrAddValue<TKey, TValue, TParam>(this IDictionary<TKey, TValue> dictionary, TKey key,
            Func<TParam, TValue> valueGenerator, TParam valueGeneratorParam)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, valueGenerator(valueGeneratorParam));
            }

            return dictionary[key];
        }
    
        /// <summary>
        /// Note: this overload is only designed for value types. Use the valueGenerator overload for reference types.
        /// </summary>
        public static TValue GetOrAddValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
            TValue value) where TValue : struct
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
            }

            return dictionary[key];
        }
    }
}