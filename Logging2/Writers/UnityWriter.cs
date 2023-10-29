using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Radish.Logging2.Writers
{
    public sealed class UnityWriter : LogWriter
    {
        [HideInCallstack]
        public override void Write(LogLevel level, Object context, string category, in ReadOnlySpan<char> formattedMessage)
        {
            Debug.unityLogger.Log(level switch
            {
                LogLevel.Info => LogType.Log,
                LogLevel.Warning => LogType.Warning,
                LogLevel.Error => LogType.Error,
                LogLevel.Exception => LogType.Exception,
                _ => throw new ArgumentOutOfRangeException(nameof(level), level, null)
            }, category, formattedMessage.ToString(), context);
        }
    }
}