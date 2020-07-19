using System.Collections.Generic;

namespace NoodleEater.DataEditor.Data {

    [System.Serializable]
    public class FieldValueContainer {
        public string className;
        public List<FieldValue> database;

        public FieldValueContainer(string classTitle, List<FieldValue> data) {
            className = classTitle;
            database = data;
        }
    }

}