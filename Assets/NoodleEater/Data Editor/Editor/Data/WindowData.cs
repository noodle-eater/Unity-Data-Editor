using System.Collections.Generic;

namespace NoodleEater.DataEditor.Data
{

    public class WindowData
    {
        private string[] _dataType = new string[] { "int", "float", "bool", "string" };
        private string[] _boolData = new string[] { "true", "false" };
        private int _currentType = 0;
        private int _boolValue = 0;
        private int _fieldCount = 1;

        private List<FieldValue> _fields = new List<FieldValue>();

        public string[] DataType { get => _dataType; }
        public string[] BoolData { get => _boolData; }
        public int CurrentType { get => _currentType; set => _currentType = value; }
        public int BoolValue { get => _boolValue; set => _boolValue = value; }
        public int FieldCount { get => _fieldCount; set => _fieldCount = value; }
        public List<FieldValue> Fields { get => _fields; }

        public void Init()
        {
            for (int i = 0; i < FieldCount; i++)
            {
                Fields.Add(new FieldValue());
            }
        }
    }
}
