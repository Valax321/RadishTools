using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    [PublicAPI]
    public static class RectExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rect WithX(this Rect r, float x)
        {
            return new Rect(x, r.y, r.width, r.height);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rect WithY(this Rect r, float y)
        {
            return new Rect(r.x, y, r.width, r.height);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rect WithWidth(this Rect r, float width)
        {
            return new Rect(r.x, r.y, width, r.height);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rect WithHeight(this Rect r, float height)
        {
            return new Rect(r.x, r.y, r.width, height);
        }
    }
}