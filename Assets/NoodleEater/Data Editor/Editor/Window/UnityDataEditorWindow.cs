using NoodleEater.DataEditor.Data;
using UnityEditor;
using UnityEngine;

namespace NoodleEater.DataEditor
{

    public class UnityDataEditorWindow : EditorWindow
    {
        private WindowData _data = new WindowData();
        private WindowUIDrawer _drawer = new WindowUIDrawer();

        [MenuItem("Unity-Data-Editor/DataWindow")]
        private static void ShowWindow()
        {
            var window = GetWindow<UnityDataEditorWindow>();
            window.titleContent = new GUIContent("Data Editor");
            window.Show();
        }

        private void OnEnable()
        {
            _data.AddField();
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginVertical("box");
            _data.ClassName = _drawer.DrawHField("Class Name", _data.ClassName);
            _drawer.DrawHorizontalLabel("Field", "Type", "Value");
            DrawField();
            EditorGUILayout.EndVertical();

            _drawer.DrawButton("Add New Field", () =>
            {
                _data.FieldCount++;
                _data.AddField();
            });
            
            _drawer.DrawButton("Save", () => {
                Debug.Log("Save");
                Debug.Log(_data.Fields.Count);
                Debug.Log(JsonUtility.ToJson(new FieldValueContainer(_data.Fields)));
                _data.Fields.ForEach((item) => Debug.Log(item.ToString()));
            });
        }

        private void DrawField()
        {
            EditorGUILayout.BeginVertical();
            for (int i = 0; i < _data.FieldCount; i++)
            {
                EditorGUILayout.BeginHorizontal();

                var field = _data.Fields[i];
                
                field.fieldName = EditorGUILayout.TextField(field.fieldName);

                field.type = (ValueType) EditorGUILayout.Popup((int)field.type, _data.DataType);

                SetValueField(field);

                EditorGUILayout.EndHorizontal();
            }
            EditorGUILayout.EndVertical();
        }

        private void SetValueField(FieldValue field)
        {
            if (field.type == ValueType.Bool)
            {
                _data.BoolValue = EditorGUILayout.Popup(_data.BoolValue, _data.BoolData, GUILayout.Width(position.width - 200));
                field.value = _data.BoolData.ToString();
            }
            else
            {
                field.value = EditorGUILayout.TextField(field.value, GUILayout.Width(position.width - 200));
            }
        }
    }
}