using System.Diagnostics;
using JetBrains.Annotations;
using Debug = UnityEngine.Debug;

namespace Radish
{
    [PublicAPI]
    public static class LogManager
    {
        public static ILogger GetCurrentClassLogger()
        {
            var callstack = new StackTrace(1);
            Debug.Assert(callstack.FrameCount >= 1);
            var callerFrame = callstack.GetFrame(0);
            var callerType = callerFrame.GetMethod().DeclaringType;
            if (callerType == null)
            {
                Debug.LogErrorFormat("Failed to get declaring type of method '{0}'", callerFrame.GetMethod().Name);
                return null;
            }
            
            return new StandardUnityLogger(callerType);
        }
    }
}