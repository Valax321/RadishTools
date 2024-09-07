using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Radish.AssetManagement
{
    public sealed class BuildScenesManifest : ScriptableObject, ISerializationCallbackReceiver
    {
        [Serializable]
        private class Entry
        {
            [SerializeField] private string m_Guid;
            [SerializeField] private string m_Path;

            public string guid => m_Guid;
            public string path => m_Path;

            public Entry(string guid, string path)
            {
                m_Guid = guid;
                m_Path = path;
            }
        }

        [PublicAPI]
        public static BuildScenesManifest Load()
        {
            #if UNITY_EDITOR
            if (Application.isEditor)
            {
                return Create();
            }
            #endif

            return Resources.Load<BuildScenesManifest>(nameof(BuildScenesManifest));
        }

        #if UNITY_EDITOR
        [PublicAPI]
        public static BuildScenesManifest Create()
        {
            var manifest = CreateInstance<BuildScenesManifest>();
            foreach (var assetGuid in AssetDatabase.FindAssets($"t:{nameof(SceneAsset)}"))
            {
                manifest.m_Entries.Add(new Entry(assetGuid, AssetDatabase.GUIDToAssetPath(assetGuid)));
            }

            manifest.OnAfterDeserialize();
            return manifest;
        }
        #endif

        [SerializeField] private List<Entry> m_Entries = new();
        [SerializeField] private Dictionary<string, Entry> m_EntryLookup = new();

        [PublicAPI]
        public string GetScenePathForAsset(SoftSceneReference scene)
        {
            if (m_EntryLookup.TryGetValue(scene.guid, out var entry))
            {
                return entry.path;
            }

            return string.Empty;
        }

        public void OnBeforeSerialize()
        {
            
        }

        public void OnAfterDeserialize()
        {
            m_EntryLookup.Clear();
            foreach (var entry in m_Entries)
            {
                m_EntryLookup.Add(entry.guid, entry);
            }
        }
    }
}