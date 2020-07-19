using UnityEditor;
using UnityEngine;

namespace NoodleEater.DataEditor
{
    public class WindowUIDrawer
    {

        public void DrawHorizontalLabel(params string[] labels)
        {
            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < labels.Length; i++)
            {
                GUILayout.FlexibleSpace();
                GUILayout.Label(labels[i]);
                GUILayout.FlexibleSpace();
            }
            EditorGUILayout.EndHorizontal();
        }

        public void DrawButton(string buttonName, System.Action OnClick) {
            if(GUILayout.Button(buttonName)) {
                OnClick?.Invoke();
            }
        }

        public string DrawHField(string label, string value) {
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label(label);
            GUILayout.FlexibleSpace();
            value = EditorGUILayout.TextField(value);
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
            return value;
        }
    }
}
