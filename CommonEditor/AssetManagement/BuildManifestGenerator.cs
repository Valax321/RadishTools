using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace Radish
{
    internal sealed class BuildManifestGenerator : IPreprocessBuildWithReport
    {
        [MenuItem("Tools/Orb Hall/Create Build Manifests", false)]
        private static void CreateManifests()
        {
            var generator = new BuildManifestGenerator();
            generator.OnPreprocessBuild(null);
        }
        
        public int callbackOrder => 1000;
        
        public void OnPreprocessBuild(BuildReport report)
        {
            var sceneManifest = BuildScenesManifest.Create();
            var resourceManifest = BuildResourcesManifest.Create();

            if (!Directory.Exists("Assets/Resources"))
                Directory.CreateDirectory("Assets/Resources");
            
            AssetDatabase.CreateAsset(sceneManifest, $"Assets/Resources/{nameof(BuildScenesManifest)}.asset");
            AssetDatabase.CreateAsset(resourceManifest, $"Assets/Resources/{nameof(BuildResourcesManifest)}.asset");
            AssetDatabase.SaveAssets();
        }
    }
}