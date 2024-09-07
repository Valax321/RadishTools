#if !ZSTRING_AVAILABLE
using System;
using System.Text;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Radish.Logging
{
    internal sealed class RadishLogger : ILogger
    {
        public string Name { get; }
        
        public RadishLogger(string name)
        {
            Name = name;
        }

        [HideInCallstack]
        private static void Write(LogLevel level, Object context, string category, string message)
        {
            foreach (var writer in LogManager.registeredLoggers)
            {
                writer.Write(level, context, category, message);
            }
        }

        [HideInCallstack]
        private static void Write(LogLevel level, Object context, string category, string message, params object[] args)
        {
            foreach (var writer in LogManager.registeredLoggers)
            {
                writer.Write(level, context, category, string.Format(message, args));
            }
        }

        [HideInCallstack]
        private static void WriteException(LogLevel level, Object context, string category, Exception ex)
        {
            var fmt = new StringBuilder();
            fmt.Append(ex);
            var span = fmt.ToString();
            foreach (var writer in LogManager.registeredLoggers)
            {
                writer.Write(level, context, category, span);
            }
        }

        [HideInCallstack]
        private static void WriteException(LogLevel level, Object context, string category, Exception ex,
            string message)
        {
            var fmt = new StringBuilder();
            fmt.Append(message);
            fmt.Append(' ');
            fmt.Append(ex);
            var span = fmt.ToString();
            foreach (var writer in LogManager.registeredLoggers)
            {
                writer.Write(level, context, category, span);
            }
        }

        [HideInCallstack]
        private static void WriteException(LogLevel level, Object context, string category, Exception ex, string format,
            params object[] args)
        {
            var fmt = new StringBuilder();
            fmt.AppendFormat(format, args);
            fmt.Append(' ');
            fmt.Append(ex);
            var span = fmt.ToString();
            foreach (var writer in LogManager.registeredLoggers)
            {
                writer.Write(level, context, category, span);
            }
        }

        [HideInCallstack]
        public void Info(string format, params object[] args) 
            => Write(LogLevel.Info, null, Name, format, args);

        [HideInCallstack]
        public void Info(Object context, string format, params object[] args) 
            => Write(LogLevel.Info, context, Name, format, args);

        [HideInCallstack]
        public void Warn(string format, params object[] args)
            => Write(LogLevel.Warning, null, Name, format, args);

        [HideInCallstack]
        public void Warn(Object context, string format, params object[] args)
            => Write(LogLevel.Warning, context, Name, format, args);

        [HideInCallstack]
        public void Error(string format, params object[] args)
            => Write(LogLevel.Error, null, Name, format, args);

        [HideInCallstack]
        public void Error(Object context, string format, params object[] args)
            => Write(LogLevel.Error, context, Name, format, args);

        [HideInCallstack]
        public void Exception(Exception exception)
            => WriteException(LogLevel.Exception, null, Name, exception);

        [HideInCallstack]
        public void Exception(Object context, Exception exception)
            => WriteException(LogLevel.Exception, context, Name, exception);

        [HideInCallstack]
        public void Exception(Exception exception, string message, params object[] args)
            => WriteException(LogLevel.Exception, null, Name, exception, message, args);

        [HideInCallstack]
        public void Exception(Object context, Exception exception, string message, params object[] args)
            => WriteException(LogLevel.Exception, context, Name, exception, message, args);
    }
}
#endif