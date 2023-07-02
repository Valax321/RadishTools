using System;
using UnityEditor;

namespace Radish
{
    [CustomPropertyDrawer(typeof(SoftAssetReference<>))]
    internal sealed class SoftAssetPropertyDrawer : SoftObjectPropertyDrawerBase
    {
        protected override string guidPropertyName => "m_Guid";
        protected override Type fieldType => fieldInfo.FieldType.GetGenericArguments()[0];
    }
}