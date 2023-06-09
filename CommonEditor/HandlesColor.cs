using System;
using UnityEditor;
using UnityEngine;

namespace OrbHall
{
    public readonly struct HandleColor : IDisposable
    {
        private readonly Color m_OldColor;
        
        public HandleColor(Color color)
        {
            m_OldColor = Handles.color;
            Handles.color = color;
        }

        public void Dispose()
        {
            Handles.color = m_OldColor;
        }
    }
}