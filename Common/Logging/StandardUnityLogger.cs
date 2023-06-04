using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace OrbHall
{
    internal sealed class StandardUnityLogger : ILogger
    {
        private readonly string m_LoggerName;
        
        public StandardUnityLogger(Type loggerType)
        {
            m_LoggerName = loggerType.FullName;
        }
        
        [HideInCallstack]
        public void Info(string format, params object[] args)
        {
            var msg = string.Format(format, args);
            Debug.unityLogger.Log(m_LoggerName, msg);
        }

        [HideInCallstack]
        public void Info(Object context, string format, params object[] args)
        {
            var msg = string.Format(format, args);
            Debug.unityLogger.Log(m_LoggerName, msg, context);
        }

        [HideInCallstack]
        public void Warn(string format, params object[] args)
        {
            var msg = string.Format(format, args);
            Debug.unityLogger.LogWarning(m_LoggerName, msg);
        }

        [HideInCallstack]
        public void Warn(Object context, string format, params object[] args)
        {
            var msg = string.Format(format, args);
            Debug.unityLogger.LogWarning(m_LoggerName, msg, context);
        }

        [HideInCallstack]
        public void Error(string format, params object[] args)
        {
            var msg = string.Format(format, args);
            Debug.unityLogger.LogError(m_LoggerName, msg);
        }

        [HideInCallstack]
        public void Error(Object context, string format, params object[] args)
        {
            var msg = string.Format(format, args);
            Debug.unityLogger.LogError(m_LoggerName, msg, context);
        }

        [HideInCallstack]
        public void Exception(Exception exception)
        {
            Debug.unityLogger.LogException(exception);
        }

        [HideInCallstack]
        public void Exception(Object context, Exception exception)
        {
            Debug.unityLogger.LogException(exception, context);
        }
    }
}