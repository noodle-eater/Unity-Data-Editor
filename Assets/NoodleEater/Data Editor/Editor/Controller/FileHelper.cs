using System.IO;

namespace NoodleEater.DataEditor.Controller
{

    public class FileHelper
    {
        public static void CreateDirectory(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }

        public static void CreateFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                FileStream fileStream = File.Create(filePath);
                fileStream.Dispose();
            }
        }

        public static void WriteText(string filePath, string text) {
            File.WriteAllText(filePath, text);
        }
    }
}