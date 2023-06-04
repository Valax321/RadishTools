using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace OrbHall
{
    [PublicAPI]
    public static class ColorExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithR(this Color c, float r)
        {
            return new Color(r, c.g, c.b, c.a);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithG(this Color c, float g)
        {
            return new Color(c.r, g, c.b, c.a);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithB(this Color c, float b)
        {
            return new Color(c.r, c.g, b, c.a);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithA(this Color c, float a)
        {
            return new Color(c.r, c.g, c.b, a);
        }
    }
}