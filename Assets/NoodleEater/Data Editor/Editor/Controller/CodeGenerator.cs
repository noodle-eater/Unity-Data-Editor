using System.Collections.Generic;
using System.IO;
using NoodleEater.DataEditor.Data;

namespace NoodleEater.DataEditor.Controller {

    public class CodeGenerator {
        
        private string _classTemplate = File.ReadAllText(Constant.CLASSTEMPLATE);
        private string _fieldTemplate = File.ReadAllText(Constant.FIELDTEMPLATE);

        public void GenerateJsonClass(List<FieldValue> container) {
            
        }

    }
}