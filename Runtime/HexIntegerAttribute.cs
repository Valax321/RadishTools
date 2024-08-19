using System;

namespace Radish
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class HexIntegerAttribute : Attribute
    {
    }
}