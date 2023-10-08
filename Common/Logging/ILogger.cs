using System;
using JetBrains.Annotations;
using Object = UnityEngine.Object;

namespace Radish.Logging
{
    public interface ILogger
    {
        [StringFormatMethod("format")]
        void Info(string format, params object[] args);
        [StringFormatMethod("format")]
        void Info(Object context, string format, params object[] args);
        
        [StringFormatMethod("format")]
        void Warn(string format, params object[] args);
        [StringFormatMethod("format")]
        void Warn(Object context, string format, params object[] args);
        
        [StringFormatMethod("format")]
        void Error(string format, params object[] args);
        [StringFormatMethod("format")]
        void Error(Object context, string format, params object[] args);
        
        void Exception(Exception exception);
        void Exception(Object context, Exception exception);
    }
}