using System;
using JetBrains.Annotations;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Radish.Logging
{
    /// <summary>
    /// Location to which a log message can be written.
    /// </summary>
    [PublicAPI]
    public interface ILogWriter
    {
        [HideInCallstack]
        void Write(LogLevel level, Object context, string category, in ReadOnlySpan<char> formattedMessage);
    }
}
