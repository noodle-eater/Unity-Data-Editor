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
    }
}
