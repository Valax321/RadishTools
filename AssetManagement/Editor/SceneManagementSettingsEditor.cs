using UnityEditor;

namespace Radish.AssetManagement
{
    [CustomEditor(typeof(SceneManagementSettings))]
    public class SceneManagementSettingsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            DrawDefaultInspector();
            if (EditorGUI.EndChangeCheck())
            {
                SceneManagementSettings.instance.Save();
            }
        }
    }
}