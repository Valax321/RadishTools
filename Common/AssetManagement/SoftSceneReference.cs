using System;
using UnityEngine;

namespace Radish
{
    [Serializable]
    public sealed class SoftSceneReference : ISoftObjectReference
    {
        [SerializeField] private string m_Guid;

        public string guid => m_Guid;

        public bool isValid => !string.IsNullOrEmpty(m_Guid);

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