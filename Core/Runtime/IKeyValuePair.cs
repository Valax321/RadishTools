namespace Radish
{
    public interface IKeyValuePair<TKey, TValue>
    {
        TKey key { get; set; }
        TValue value { get; set; }
    }

    public static class KeyValuePairExtensions
    {
        public static void Deconstruct<TKey, TValue>(this IKeyValuePair<TKey, TValue> data, out TKey outKey,
            out TValue outValue)
        {
            outKey = data.key;
            outValue = data.value;
        }
    }
}