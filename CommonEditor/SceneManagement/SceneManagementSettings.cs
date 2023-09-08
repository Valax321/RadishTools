using Radish.Settings;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Radish.SceneManagement
{
    public sealed class SceneManagementSettings : ProjectSettingsRepository
    {
        public static SceneManagementSettings instance
        {
            get
            {
                if (!s_Instance)
                    s_Instance = Load<SceneManagementSettings>();
                return s_Instance;
            }
        }
        
        private static SceneManagementSettings s_Instance;

        [SerializeField] private SceneAsset m_EditorBeginPlayScene;
        public SceneAsset editorBeginPlayScene => m_EditorBeginPlayScene;

        internal void Save()
        {
            Save(this);
        }

        [InitializeOnLoadMethod]
        private static void Init()
        {
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private static void OnPlayModeStateChanged(PlayModeStateChange mode)
        {
            if (mode == PlayModeStateChange.ExitingEditMode)
            {
                EditorSceneManager.playModeStartScene = instance.m_EditorBeginPlayScene;
            }
        }

        [SettingsProvider]
        private static SettingsProvider GetSceneManagementSettingsProvider()
        {
            var provider = AssetSettingsProvider.CreateProviderFromObject("Game/Scene Management", instance);
            provider.keywords = SettingsProvider.GetSearchKeywordsFromSerializedObject(new SerializedObject(instance));
            return provider;
        }
    }
}