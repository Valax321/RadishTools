using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Radish
{
    [PublicAPI]
    public static class ListExtensions
    {
        public static int IndexOf<T>(this IReadOnlyList<T> source, T value, IEqualityComparer<T> comparer)
        {
            for (var i = 0; i < source.Count; i++)
            {
                if (comparer.Equals(source[i], value))
                    return i;
                i++;
            }

            return -1;
        }
    
        public static IEnumerable<T> GetRange<T>(this List<T> list, Range range)
        {
            var (start, length) = range.GetOffsetAndLength(list.Count);
            return list.GetRange(start, length);
        }

        public static bool TryGetAtIndex<T>(this IReadOnlyList<T> list, int index, out T outItem)
        {
            if (!(index < 0 || index >= list.Count))
            {
                outItem = list[index];
                return true;
            }

            outItem = default;
            return false;
        }
    }
}