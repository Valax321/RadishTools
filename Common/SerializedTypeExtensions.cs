using System;
using JetBrains.Annotations;
using Radish;

namespace Radish
{
    [PublicAPI]
    public static class SerializedTypeExtensions
    {
        public static SerializedType ToSerializedType(this Type type)
        {
            return new SerializedType
            {
                type = type
            };
        }
    }
}