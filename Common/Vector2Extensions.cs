using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

[PublicAPI]
// ReSharper disable once CheckNamespace
public static class Vector2Extensions
{
    #region Vector2

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 WithX(this Vector2 v, float x)
    {
        return new Vector2(x, v.y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 WithY(this Vector2 v, float y)
    {
        return new Vector2(v.x, y);
    }
    
    #endregion

    #region Vector2Int

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2Int WithX(this Vector2Int v, int x)
    {
        return new Vector2Int(x, v.y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2Int WithY(this Vector2Int v, int y)
    {
        return new Vector2Int(v.x, y);
    }

    #endregion
}