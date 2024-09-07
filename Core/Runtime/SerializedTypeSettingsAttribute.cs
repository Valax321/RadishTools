using System;

namespace Radish
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class SerializedTypeSettingsAttribute : Attribute
    {
        public Type[] constraintTypes { get; }

        public SerializedTypeSettingsAttribute(params Type[] constraintTypes)
        {
            this.constraintTypes = constraintTypes;
        }
    }
}