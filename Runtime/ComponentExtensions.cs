using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    [PublicAPI]
    public static class ComponentExtensions
    {
        public static T GetOrCreateComponent<T>(this GameObject go, HideFlags defaultFlags = HideFlags.None) where T : Component
        {
            if (go.TryGetComponent(out T c))
            {
                c.hideFlags |= defaultFlags;
                return c;
            }

            c = go.AddComponent<T>();
            c.hideFlags |= defaultFlags;
            return c;
        }

        public static GameObject GetOrCreateNamedChild(this GameObject go, string name,
            HideFlags defaultFlags = HideFlags.None)
        {
            var t = go.transform.Find(name);
            if (!t)
            {
                var newGo = new GameObject(name)
                {
                    hideFlags = defaultFlags
                };

                t = newGo.transform;
                t.transform.SetParent(go.transform, false);
            }
            else
            {
                t.gameObject.hideFlags |= defaultFlags;
            }
            
            return t.gameObject;
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