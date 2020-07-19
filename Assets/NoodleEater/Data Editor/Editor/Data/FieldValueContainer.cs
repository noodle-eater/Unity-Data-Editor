using System.Collections.Generic;

namespace NoodleEater.DataEditor.Data
{

    [System.Serializable]
    public class FieldValueContainer
    {
        public string className;
        public List<FieldValue> database;

        public FieldValueContainer(string classTitle, List<FieldValue> data)
        {
            className = classTitle;
            database = data;
        }

        public string ToJson()
        {
            var builder = new System.Text.StringBuilder();
            builder.AppendLine("{");

            for (int i = 0; i < database.Count; i++)
            {
                var data = database[i];

                if (data.type == ValueType.String)
                {
                    builder.Append($"\"{data.fieldName}\": \"{data.value}\"");
                }
                else
                {
                    builder.Append($"\"{data.fieldName}\": {data.value}");
                }

                if (i < database.Count - 1)
                {
                    builder.AppendLine(",");
                }
                else
                {
                    builder.AppendLine();
                }
            }

            builder.AppendLine("}");
            return builder.ToString();
        }
    }
}

