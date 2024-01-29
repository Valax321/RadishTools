using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Radish
{
    [Serializable]
    public sealed class SoftAssetReference<T> : ISoftObjectReference where T : Object
    {
        [SerializeField] private string m_Guid;

        public string guid => m_Guid;
        public bool isValid => !string.IsNullOrEmpty(m_Guid);
        public string path => BuildResourcesManifest.instance.GetResourcePathForAsset(this);

        public override string ToString()
        {
#if !UNITY_EDITOR
            return string.Format("{0} (Scene)", m_Guid);
#else
            return string.Format("{0} (Scene)", UnityEditor.AssetDatabase.GUIDToAssetPath(m_Guid));
#endif
        }
    }
}