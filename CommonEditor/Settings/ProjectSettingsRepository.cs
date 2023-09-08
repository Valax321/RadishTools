using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Radish.Settings
{
    public abstract class ProjectSettingsRepository : ScriptableObject
    {
        private static string GetSettingsPathForType(Type t)
        {
            return Path.Combine("ProjectSettings", "GameSettings", $"{t.Name}.json");
        }
        
        public static T Load<T>() where T : ProjectSettingsRepository
        {
            var settings = CreateInstance<T>();
            var settingsPath = GetSettingsPathForType(typeof(T));
            if (File.Exists(settingsPath))
            {
                EditorJsonUtility.FromJsonOverwrite(File.ReadAllText(settingsPath), settings);
            }
            return settings;
        }

        public static void Save<T>(T settings) where T : ProjectSettingsRepository
        {
            if (!settings)
                return;

            var settingsPath = GetSettingsPathForType(typeof(T));
            var settingsDir = Path.GetDirectoryName(settingsPath);
            if (!Directory.Exists(settingsDir) && !string.IsNullOrEmpty(settingsDir))
                Directory.CreateDirectory(settingsDir);
            
            File.WriteAllText(settingsPath, EditorJsonUtility.ToJson(settings, true));
        }
    }
}