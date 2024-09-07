using System;
using System.IO;
using Radish.Logging;
using UnityEngine;
using ILogger = Radish.Logging.ILogger;

namespace Radish.Debugging
{
    public class ScreenshotHandler : MonoBehaviour
    {
        private static readonly ILogger Logger = LogManager.GetLoggerForType(typeof(ScreenshotHandler));

        private static string GetScreenshotRootDir()
        {
            if (Application.isEditor)
                return Directory.GetCurrentDirectory();
            return Application.persistentDataPath;
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F9))
            {
                var rootPath = GetScreenshotRootDir();
                Directory.CreateDirectory(Path.Combine(rootPath, "Screenshots"));
                var path = Path.Combine(rootPath, "Screenshots", $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.png");
                ScreenCapture.CaptureScreenshot(path);
                Logger.Info(this, "Saved screenshot to {0}", path);
            }
        }
    }
}