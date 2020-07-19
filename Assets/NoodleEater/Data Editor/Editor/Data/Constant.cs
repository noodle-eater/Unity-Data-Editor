using UnityEngine;

namespace NoodleEater.DataEditor.Data {
    public class Constant {
        
        public static string SCRIPTPATH = Application.dataPath + "/Scripts/";
        public static string PROJECTHPATH = Application.dataPath.Substring(0, Application.dataPath.Length - 6);
        public static string DATACACHE = PROJECTHPATH + "/Temp/NoodleEater/Data";
        public static string GENERATEDPATH = SCRIPTPATH + "/Generated/";
        public static string TEMPLATEPATH = Application.dataPath + "/NoodleEater/Data Editor/Editor/Template/";

        public static string JSONCACHEPATH = DATACACHE + "/cache.json";
        public static string CLASSTEMPLATE = TEMPLATEPATH + "/class.txt";
        public static string FIELDTEMPLATE = TEMPLATEPATH + "/field.txt";
        public static string NAMESPACETEMPLATE = TEMPLATEPATH + "/namespace.txt";
    }
}