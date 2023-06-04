using System.Linq;
using JetBrains.Annotations;

namespace OrbHall
{
    [PublicAPI]
    public static class ArrayExtensions
    {
        public static T[] With<T>(this T[] arr, T item)
        {
            if (arr.Contains(item))
                return arr;

            var newArr = new T[arr.Length + 1];
            for (var i = 0; i < arr.Length; i++)
                newArr[i] = arr[i];
            newArr[arr.Length] = item;
            return newArr;
        }

        public static T[] Without<T>(this T[] arr, T item)
        {
            if (!arr.Contains(item))
                return arr;

            var newArr = new T[arr.Length - 1];
            var i2 = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (Equals(arr[i], item))
                    continue;

                newArr[i2++] = arr[i];
            }

            return newArr;
        }
    }
}