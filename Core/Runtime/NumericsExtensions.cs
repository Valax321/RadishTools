using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using NVector2 = System.Numerics.Vector2;
using NVector3 = System.Numerics.Vector3;

namespace Radish
{
    [PublicAPI]
    public static class NumericsExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ToUnity(this NVector3 v)
        {
            return new Vector3(v.X, v.Y, v.Z);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 ToUnity(this NVector2 v)
        {
            return new Vector3(v.X, v.Y);
        }
    }
}