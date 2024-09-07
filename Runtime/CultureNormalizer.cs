#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Globalization;
using UnityEngine;

namespace Radish
{
    internal static class CultureNormalizer
    {
#if UNITY_EDITOR
        [InitializeOnLoadMethod]
#endif
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        private static void NormalizeCultureInfo()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
        }
    }
}