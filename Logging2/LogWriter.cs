using System;
using JetBrains.Annotations;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Radish.Logging2
{
    /// <summary>
    /// Location to which a log message can be written.
    /// </summary>
    [PublicAPI]
    public abstract class LogWriter
    {
        [HideInCallstack]
        public abstract void Write(LogLevel level, Object context, string category, in ReadOnlySpan<char> formattedMessage);
    }
}
