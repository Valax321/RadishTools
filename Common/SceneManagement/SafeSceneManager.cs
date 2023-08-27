#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Radish.SceneManagement
{
    [PublicAPI]
    public static class SafeSceneManager
    {
        public delegate void OnSceneLoadBegin(string scenePath);
        
        public static BuildScenesManifest buildScenesManifest { get; private set; }
        public static OnSceneLoadBegin onSceneLoadBegin { get; set; }
        
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Init()
        {
            buildScenesManifest = BuildScenesManifest.Load();
        }
        
        public static void LoadScene(SoftSceneReference scene, LoadSceneMode mode)
        {
            var scenePath = buildScenesManifest.GetScenePathForAsset(scene);
            if (string.IsNullOrEmpty(scenePath))
            {
                Debug.LogErrorFormat("Failed to get scene path for '{0}'", scene.guid);
                return;
            }
            
            onSceneLoadBegin?.Invoke(scenePath);
#if UNITY_EDITOR
            if (Application.isEditor)
                EditorSceneManager.LoadSceneInPlayMode(scenePath, new LoadSceneParameters(mode));
#endif
            SceneManager.LoadScene(scenePath, mode);
        }
        
        public static AsyncOperation LoadSceneAsync(SoftSceneReference scene, LoadSceneMode mode)
        {
            var scenePath = buildScenesManifest.GetScenePathForAsset(scene);
            if (string.IsNullOrEmpty(scenePath))
            {
                Debug.LogErrorFormat("Failed to get scene path for '{0}'", scene.guid);
                return null;
            }
            
            onSceneLoadBegin?.Invoke(scenePath);
#if UNITY_EDITOR
            if (Application.isEditor)
                return EditorSceneManager.LoadSceneAsyncInPlayMode(scenePath, new LoadSceneParameters(mode));
#endif
            return SceneManager.LoadSceneAsync(scenePath, mode);
        }

        public static AsyncOperation UnloadSceneAsync(SoftSceneReference scene, UnloadSceneOptions options = UnloadSceneOptions.None)
        {
            var scenePath = buildScenesManifest.GetScenePathForAsset(scene);
            if (string.IsNullOrEmpty(scenePath))
            {
                Debug.LogErrorFormat("Failed to get scene path for '{0}'", scene.guid);
                return null;
            }

            return SceneManager.UnloadSceneAsync(scenePath, options);
        }

        public static void SetSceneActive(SoftSceneReference scene)
        {
            var scenePath = buildScenesManifest.GetScenePathForAsset(scene);
            if (string.IsNullOrEmpty(scenePath))
            {
                Debug.LogErrorFormat("Failed to get scene path for '{0}'", scene.guid);
                return;
            }

            var scn = SceneManager.GetSceneByPath(scenePath);
            if (scn.IsValid())
            {
                SceneManager.SetActiveScene(scn);
            }
        }

        public static bool TryGetScene(SoftSceneReference scene, out Scene sceneInfo)
        {
            var scenePath = buildScenesManifest.GetScenePathForAsset(scene);
            if (string.IsNullOrEmpty(scenePath))
            {
                Debug.LogErrorFormat("Failed to get scene path for '{0}'", scene.guid);
                sceneInfo = new Scene();
                return false;
            }

            sceneInfo = SceneManager.GetSceneByPath(scenePath);
            return sceneInfo.IsValid();
        }
    }
}