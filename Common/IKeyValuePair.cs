namespace OrbHall
{
    public interface IKeyValuePair<TKey, TValue>
    {
        TKey key { get; set; }
        TValue value { get; set; }
    }
}