using System.Collections.Generic;
using NoodleEater.DataEditor.Data;
using NoodleEater.DataEditor.Pattern;

namespace NoodleEater.DataEditor.Controller
{
    public class DataEditorController : BaseSingleton<DataEditorController>
    {

        private Dictionary<string, FieldValue> _dataContainer = new Dictionary<string, FieldValue>();

        public void SetData(string fieldName, string type, string value)
        {
            if (!_dataContainer.ContainsKey(fieldName))
            {
                _dataContainer.Add(fieldName, new FieldValue { type = type, value = value });
            }
            else
            {
                _dataContainer[fieldName].fieldName = fieldName;
                _dataContainer[fieldName].type = type;
                _dataContainer[fieldName].value = value;
            }
        }

    }
}