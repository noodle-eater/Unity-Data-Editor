using UnityEngine;
using UnityEditor;

public class DataEditorWindow : EditorWindow {

    [MenuItem("Unity-Data-Editor/DataWindow")]
    private static void ShowWindow() {
        var window = GetWindow<DataEditorWindow>();
        window.titleContent = new GUIContent("DataWindow");
        window.Show();
    }

    private void OnGUI() {
        
    }
}