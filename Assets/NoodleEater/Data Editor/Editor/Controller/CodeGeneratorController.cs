using System.Collections.Generic;
using System.IO;
using NoodleEater.DataEditor.Data;
using UnityEditor;

namespace NoodleEater.DataEditor.Controller {

    public class CodeGeneratorController {
        
        public void CreateJson(FieldValueContainer container) {
            string jsonPath = Constant.GENERATEDDATAPATH + $"/{container.className}.json";
            FileHelper.CreateDirectory(Constant.GENERATEDDATAPATH);
            FileHelper.CreateFile(jsonPath);
            File.WriteAllText(jsonPath, container.ToJson());
            AssetDatabase.Refresh();
        }

    }
}