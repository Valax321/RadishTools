using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    [PublicAPI]
    public static class Vector3Extensions
    {
        #region Vector3

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithX(this Vector3 v, float x)
        {
            return new Vector3(x, v.y, v.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithY(this Vector3 v, float y)
        {
            return new Vector3(v.x, y, v.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithScale(this Vector3 v, float scale)
        {
            v *= scale;
            return v;
        }

        public static Vector3 WithRandomConeOffset(this Vector3 dir, float maxAngle)
        {
            var xSpread = Random.Range(-maxAngle, maxAngle);
            var ySpread = Random.Range(-maxAngle, maxAngle);
            var spread = new Vector3(xSpread, ySpread, 0.0f);
            var newRot = Quaternion.LookRotation(dir) * Quaternion.Euler(spread);
            return newRot * Vector3.forward;
        }

        #endregion

        #region Vector3Int

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int WithX(this Vector3Int v, int x)
        {
            return new Vector3Int(x, v.y, v.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int WithY(this Vector3Int v, int y)
        {
            return new Vector3Int(v.x, y, v.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int WithZ(this Vector3Int v, int z)
        {
            return new Vector3Int(v.x, v.y, z);
        }

        #endregion
    }
}