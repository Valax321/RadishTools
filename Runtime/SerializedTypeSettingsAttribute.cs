using System;

namespace Radish
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class SerializedTypeSettingsAttribute : Attribute
    {
        public Type constraintType { get; }

        public SerializedTypeSettingsAttribute(Type constraintType)
        {
            this.constraintType = constraintType;
        }
    }
}