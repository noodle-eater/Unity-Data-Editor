using NoodleEater.DataEditor.Data;
using UnityEngine;

namespace NoodleEater.DataEditor.Controller {

    public class Utility {
        public static int StringToInt(string value) {
            if(string.IsNullOrEmpty(value)) {
                return 0;
            } else {
                return value == "true" ? 1 : 0;
            }
        }

        public static string IntToString(int value) {
            return value == 1 ? "true" : "false";
        }

        public static void CreateCache(FieldValueContainer container, string json) {
            FileHelper.CreateDirectory(Constant.DATACACHE);
            FileHelper.CreateFile(Constant.JSONCACHEPATH);
            FileHelper.WriteText(Constant.JSONCACHEPATH, json);
            Debug.Log(container.ToJson());
        }
    }
}