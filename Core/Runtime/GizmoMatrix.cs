using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    [PublicAPI]
    public readonly struct GizmoMatrix : IDisposable
    {
        private readonly Matrix4x4 m_OldMatrix;
        
        public GizmoMatrix(Matrix4x4 matrix)
        {
            m_OldMatrix = Gizmos.matrix;
            Gizmos.matrix = matrix;
        }

        public void Dispose()
        {
            Gizmos.matrix = m_OldMatrix;
        }
    }
}