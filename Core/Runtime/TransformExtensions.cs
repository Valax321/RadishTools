using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    [PublicAPI]
    public static class TransformExtensions
    {
        public static IEnumerable<Transform> GetChildren(this Transform transform)
        {
            for (var i = 0; i < transform.childCount; i++)
                yield return transform.GetChild(i);
        }

        public static Bounds CalcBoundingBoxForObject(this Transform transform)
        {
            var bounds = new Bounds(transform.position, Vector3.zero);
            var renderers = new List<Renderer>();
            transform.GetComponentsInChildren(true, renderers);

            foreach (var r in renderers)
            {
                bounds.Encapsulate(r.bounds);
            }

            return bounds;
        }
    }
}