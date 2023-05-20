using System;
using OrbHall;

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