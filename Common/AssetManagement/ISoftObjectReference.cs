namespace Radish
{
    public interface ISoftObjectReference
    {
        string guid { get; }
        bool isValid { get; }
    }
}