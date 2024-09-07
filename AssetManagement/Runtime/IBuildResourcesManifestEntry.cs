using System;

namespace Radish.AssetManagement
{
    public interface IBuildResourcesManifestEntry
    {
        string guid { get; }
        string path { get; }
        Type type { get; }
    }
}