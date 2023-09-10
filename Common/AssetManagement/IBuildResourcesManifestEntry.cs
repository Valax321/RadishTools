using System;

namespace Radish
{
    public interface IBuildResourcesManifestEntry
    {
        string guid { get; }
        string path { get; }
        Type type { get; }
    }
}