using System.Collections.Generic;

namespace NoodleEater.DataEditor.Data {

    [System.Serializable]
    public class FieldValueContainer {
        public List<FieldValue> database;

        public FieldValueContainer(List<FieldValue> data) {
            database = data;
        }
    }

}