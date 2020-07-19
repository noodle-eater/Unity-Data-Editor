using NoodleEater.DataEditor.Data;
using UnityEditor;
using UnityEngine;
namespace NoodleEater.DataEditor
{

    public class UnityDataEditorWindow : EditorWindow
    {

        [MenuItem("Unity-Data-Editor/DataWindow")]
#pragma warning disable IDE0051 // Remove unused private members
        private static void ShowWindow()
        {
            var window = GetWindow<UnityDataEditorWindow>();
            window.titleContent = new GUIContent("DataWindow");
            window.Show();
        }
#pragma warning restore IDE0051 // Remove unused private members

        private void OnGUI()
        {
            EditorGUILayout.BeginVertical("box");
            DrawHeader();
            DrawField();
            EditorGUILayout.EndVertical();
        }

        private void DrawHeader()
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label("Field");
            GUILayout.FlexibleSpace();
            GUILayout.Label("Type");
            GUILayout.FlexibleSpace();
            GUILayout.Label("Value");
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
        }

        private void DrawField()
        {
            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < WindowData.Instance.FieldCount; i++)
            {
                EditorGUILayout.TextField("");
                WindowData.Instance.CurrentType = EditorGUILayout.Popup(WindowData.Instance.CurrentType, WindowData.Instance.DataType);
                if (WindowData.Instance.DataType[WindowData.Instance.CurrentType] == "bool")
                {
                    WindowData.Instance.BoolValue = EditorGUILayout.Popup(WindowData.Instance.BoolValue, WindowData.Instance.BoolData, GUILayout.Width(position.width - 200));
                }
                else
                {
                    EditorGUILayout.TextField("", GUILayout.Width(position.width - 200));
                }
            }
            EditorGUILayout.EndHorizontal();
        }
    }
}