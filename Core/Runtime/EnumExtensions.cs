using System;
using JetBrains.Annotations;

namespace Radish
{
    public static class EnumExtensions
    {
        [PublicAPI]
        public static bool HasFlagT<T>(this T flags, T testFlags) where T : Enum, IConvertible
        {
            var flagsAsLongestType = flags.ToInt64(null);
            var testFlagsAsLongestType = testFlags.ToInt64(null);

            return (flagsAsLongestType & testFlagsAsLongestType) != 0;
        }
    }
}