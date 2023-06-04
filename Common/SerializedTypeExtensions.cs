using System;
using JetBrains.Annotations;
using OrbHall;

namespace OrbHall
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