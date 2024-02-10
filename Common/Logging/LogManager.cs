using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
using Radish.Logging.Writers;

namespace Radish.Logging
{
    [PublicAPI]
    public static class LogManager
    {
        internal static List<ILogWriter> registeredLoggers { get; } = new()
        {
            new UnityWriter()
        };

#if UNITY_WEBGL
        [Obsolete("GetCurrentClassLogger() cannot access stacktrace info in WebGL player builds. Use GetLoggerForType() on WebGL instead.")]
#endif
        public static ILogger GetCurrentClassLogger()
        {
#if UNITY_WEBGL && !UNITY_EDITOR

            // In WebGL builds accessing the StackTrace gives an unclear error message.
            // Avoid using it.
            return new RadishLogger("???");
            
#else

            var trace = new StackTrace(1);
            Debug.Assert(trace.FrameCount >= 1);

            var callerFrame = trace.GetFrame(0);
            var callerType = callerFrame.GetMethod().DeclaringType;
            if (callerType == null)
            {
                Debug.Print("Failed to get declaring type of method: '{0}'", callerFrame.GetMethod().Name);
                return null;
            }

            return new RadishLogger(callerType.FullName);

#endif
        }

        public static ILogger GetLoggerForType(Type t)
        {
            return new RadishLogger(t.FullName);
        }

        public static void RegisterLogWriter(ILogWriter writer)
        {
            if (writer is null)
                throw new ArgumentNullException(nameof(writer));

            registeredLoggers.Add(writer);
        }
    }
}