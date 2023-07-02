using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    [PublicAPI]
    public static class QuaternionExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion WithPitch(this Quaternion q, float pitch)
        {
            var e = q.eulerAngles;
            return Quaternion.Euler(pitch, e.y, e.z);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion WithRoll(this Quaternion q, float roll)
        {
            var e = q.eulerAngles;
            return Quaternion.Euler(e.x, e.y, roll);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion WithYaw(this Quaternion q, float yaw)
        {
            var e = q.eulerAngles;
            return Quaternion.Euler(q.x, yaw, e.z);
        }
    }
}