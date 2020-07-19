namespace NoodleEater.DataEditor.Data {
    public class FieldValue {
        public string fieldName;
        public string type;
        public string value;

        public override string ToString() {
            return $"FieldName: {fieldName}, Type: {type}, Value: {value}";
        }
    }
}