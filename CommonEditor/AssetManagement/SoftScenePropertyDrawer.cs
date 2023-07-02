using System;
using UnityEditor;

namespace Radish
{
    [CustomPropertyDrawer(typeof(SoftSceneReference))]
    internal sealed class SoftScenePropertyDrawer : SoftObjectPropertyDrawerBase
    {
        protected override string guidPropertyName => "m_Guid";
        protected override Type fieldType => typeof(SceneAsset);
    }
}