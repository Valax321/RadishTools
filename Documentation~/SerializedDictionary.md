# SerializedDictionary

SerializedDictionary is a subclass of .NET's normal Dictionary type that can be serialized by Unity (assuming the key and value types are also serializable).

If Odin is installed in your project, these dictionaries will use its UI element for dictionaries without requiring its serialization system.

There are two versions available:

- `SerializedDictionary<TKey, TValue>` works exactly like a normal dictionary.
- `SerializedDictionary<TKey, TValue, TKeyValuePair>` allows specifying a custom type that is used for the key-value pair. This allows for more complex customisation of how the dictionary entries are stored. Key value pair types must implement the `IKeyValuePair<TKey, TValue>` interface.
