namespace NoodleEater.DataEditor.Data {

    [System.Serializable]
    public class FieldValue {
        public string fieldName;
        public ValueType type;
        public string value;

        public override string ToString() {
            return $"FieldName: {fieldName}, Type: {type}, Value: {value}";
        }
    }
}