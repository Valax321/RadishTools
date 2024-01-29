using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
using Radish.Logging2.Writers;

namespace Radish.Logging2
{
    [PublicAPI]
    public static class LogManager
    {
        internal static List<LogWriter> registeredLoggers { get; } = new()
        {
            new UnityWriter()
        };

        public static ILogger GetCurrentClassLogger()
        {
            // Not sure if Stacktrace is AOT-compatible
            // If it is, we can just exclude class names in AOT builds since they're probably
            // for release anyway.

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

        public static void RegisterLogWriter(LogWriter writer)
        {
            if (writer is null)
                throw new ArgumentNullException(nameof(writer));

            registeredLoggers.Add(writer);
        }
    }
}
