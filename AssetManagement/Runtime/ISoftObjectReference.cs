namespace Radish.AssetManagement
{
    public interface ISoftObjectReference
    {
        string guid { get; }
        bool isValid { get; }
    }
}