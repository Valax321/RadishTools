using System;
using UnityEngine;

namespace Radish.Rewired
{
    [Serializable]
    public sealed class ActionReference : IEquatable<ActionReference>
    {
        [SerializeField] private string m_Name;
        [SerializeField] private int m_Id = -1;

        public string name => m_Name;
        public int id => m_Id;

        public bool Equals(ActionReference other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return m_Id == other.m_Id;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is ActionReference other && Equals(other);
        }

        public override int GetHashCode()
        {
            return m_Id;
        }
    }
}