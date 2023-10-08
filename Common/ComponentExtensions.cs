using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
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

        public static T Q<T>(this GameObject go, string path) where T : Component => Q<T>(go.transform, path);
        
        public static T Q<T>(this Transform transform, string path) where T : Component
        {
            if (!transform)
                throw new ArgumentNullException(nameof(transform));
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            var t = transform.Find(path);
            if (t && t.TryGetComponent(out T cmp))
                return cmp;
            return null;
        }
    }
}