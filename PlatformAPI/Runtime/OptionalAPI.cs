using System;
using JetBrains.Annotations;

namespace Radish.PlatformAPI
{
    [PublicAPI]
    public class OptionalAPI<T>
    {
        public bool isSupported { get; }
        public T impl { get; }
        public string unsupportedReason { get; } = string.Empty;

        internal OptionalAPI(T api)
        {
            if (api is null)
                throw new ArgumentNullException(nameof(api));
            
            isSupported = true;
            impl = api;
        }

        internal OptionalAPI(string unsupportedReason)
        {
            isSupported = false;
            this.unsupportedReason = unsupportedReason;
        }

        public static OptionalAPI<T> CreateForImplementation(T interfaceImpl)
        {
            return new OptionalAPI<T>(interfaceImpl);
        }

        public static OptionalAPI<T> CreateNotSupported(string unsupportedReason)
        {
            return new OptionalAPI<T>(unsupportedReason);
        }
    }
}