using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    [PublicAPI]
    public static class Vector4Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithX(this Vector4 v, float x)
        {
            return new Vector4(x, v.y, v.z, v.w);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithY(this Vector4 v, float y)
        {
            return new Vector4(v.x, y, v.z, v.w);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithZ(this Vector4 v, float z)
        {
            return new Vector4(v.x, v.y, z, v.w);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithW(this Vector4 v, float w)
        {
            return new Vector4(v.x, v.y, v.z, w);
        }
    }
}