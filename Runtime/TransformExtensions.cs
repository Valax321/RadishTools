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
    }
}