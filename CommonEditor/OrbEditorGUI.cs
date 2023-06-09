using System;
using UnityEditor;
using UnityEngine;

namespace OrbHall
{
    public static class OrbEditorGUI
    {
        public static bool EditorPrefsFoldoutHeaderGroup(string key, GUIContent content, GUIStyle style = null,
            Action<Rect> menuAction = null, GUIStyle menuIcon = null)
        {
            var keyState = EditorPrefs.GetBool(key, true);
            var returnValue = EditorGUILayout.BeginFoldoutHeaderGroup(keyState, content, style, menuAction, menuIcon);
            EditorPrefs.SetBool(key, returnValue);
            return returnValue;
        }
    }
}