using System;
using JetBrains.Annotations;
using Object = UnityEngine.Object;

namespace Radish.Logging2
{
    /// <summary>
    /// Location to which a log message can be written.
    /// </summary>
    [PublicAPI]
    public abstract class LogWriter
    {
        public abstract void Write(LogLevel level, Object context, string category, in ReadOnlySpan<char> formattedMessage);
    }
}
