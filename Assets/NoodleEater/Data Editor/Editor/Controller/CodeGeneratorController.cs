using System.IO;
using NoodleEater.DataEditor.Data;
using NoodleEater.DataEditor.Generator;
using UnityEditor;
using UnityEngine;

namespace NoodleEater.DataEditor.Controller {

    public class CodeGeneratorController {
        
        private ClassGenerator _classGenerator = new ClassGenerator();

        public void Init() {
            _classGenerator.Init();
        }

        public void CreateJson(FieldValueContainer container) {
            string jsonPath = Constant.GENERATEDDATAPATH + $"/{container.className.ToLower()}.json";
            FileHelper.CreateDirectory(Constant.GENERATEDDATAPATH);
            FileHelper.CreateFile(jsonPath);
            File.WriteAllText(jsonPath, container.ToJson());
            Debug.Log($"<color=green>Json file is created in {jsonPath}</color>");
            AssetDatabase.Refresh();
        }

        public void GenerateClass(FieldValueContainer container) {
            Debug.Log($"<color=green>{container.className} class is generated in {Constant.GENERATEDSCRIPTPATH}");
            _classGenerator.GenerateClass(container);
        }

    }
}