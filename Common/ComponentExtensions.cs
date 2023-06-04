using JetBrains.Annotations;
using UnityEngine;

namespace OrbHall
{
    [PublicAPI]
    public static class ComponentExtensions
    {
        public static T GetOrCreateComponent<T>(this GameObject go) where T : Component
        {
            if (go.TryGetComponent(out T c))
                return c;

            return go.AddComponent<T>();
        }
    }
}