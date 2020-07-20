using System.IO;
using NoodleEater.DataEditor.Controller;
using NoodleEater.DataEditor.Data;
using UnityEditor;
using UnityEngine;

namespace NoodleEater.DataEditor.Generator
{
    public class ClassGenerator
    {
        private string _classTemplate;
        private string _fieldTemplate;
        private string _classKeyword = "__CLASS__";
        private string _fieldKeyword = "__FIELD__";
        private string _typeKeyword = "__TYPE __";
        private string _varNameKeyword = "__VARNAME__";

        public void Init() {
            _classTemplate = File.ReadAllText(Constant.CLASSTEMPLATE);
            _fieldTemplate = File.ReadAllText(Constant.FIELDTEMPLATE);

            Debug.Log(_classTemplate);
            Debug.Log(_fieldTemplate);
        }

        public void GenerateClass(FieldValueContainer container) {
            string scripts = _classTemplate.Replace(_classKeyword, container.className);

            string fields = string.Empty;
            Debug.Log(container.database.Count);
            foreach(var item in container.database) {
                string temp = _fieldTemplate.Replace(_typeKeyword, item.type.ToString().ToLower());
                temp = temp.Replace(_varNameKeyword, item.fieldName);
                fields += $"\t{temp}\r\n";
            }

            scripts = scripts.Replace(_fieldKeyword, fields);

            var classPath = Constant.GENERATEDSCRIPTPATH + $"/{container.className}.cs";
            FileHelper.CreateDirectory(Constant.GENERATEDSCRIPTPATH);
            FileHelper.CreateFile(classPath);
            File.WriteAllText(classPath, scripts);
            AssetDatabase.Refresh();
        }

    }

}