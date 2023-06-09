using System;
using UnityEngine;

namespace OrbHall
{
    public readonly struct GizmoColor : IDisposable
    {
        private readonly Color m_OldColor;
        
        public GizmoColor(Color color)
        {
            m_OldColor = Gizmos.color;
            Gizmos.color = color;
        }

        public void Dispose()
        {
            Gizmos.color = m_OldColor;
        }
    }
}