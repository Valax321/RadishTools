using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace Radish
{
    internal static class CreateMaterialFromSelection
    {
        [MenuItem("Assets/Create/Materials From Selection", false, 302)]
        private static void Create()
        {
            AssetDatabase.StartAssetEditing();

            List<Material> mats = new();

            foreach (var asset in Selection.GetFiltered<Texture>(SelectionMode.Assets))
            {
                Material mat;
#if UNITY_6000_0_OR_NEWER
                if (GraphicsSettings.defaultRenderPipeline)
#else
                if (GraphicsSettings.renderPipelineAsset)
#endif
                {
                    mat = new Material(GraphicsSettings.currentRenderPipeline.defaultMaterial)
                    {
                        name = asset.name,
                        mainTexture = asset,
                        color = Color.white
                    };
                }
                else
                {
                    mat = new Material(Shader.Find("Standard"))
                    {
                        name = asset.name,
                        mainTexture = asset,
                        color = Color.white
                    };
                }

                if (!mat)
                    return;

                var texPath = AssetDatabase.GetAssetPath(asset);
                var matPath = Path.ChangeExtension(texPath, "mat");
                matPath = AssetDatabase.GenerateUniqueAssetPath(matPath);
                AssetDatabase.CreateAsset(mat, matPath);
                mats.Add(mat);
            }

            AssetDatabase.StopAssetEditing();
            Selection.objects = mats.Select(x => (Object)x).ToArray();
        }
    }
}