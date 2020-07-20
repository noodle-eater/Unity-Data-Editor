using System.Collections.Generic;
using System.IO;
using NoodleEater.DataEditor.Data;
using NoodleEater.DataEditor.Generator;
using UnityEditor;

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
            AssetDatabase.Refresh();
        }

        public void GenerateClass(FieldValueContainer container) {
            _classGenerator.GenerateClass(container);
        }

    }
}