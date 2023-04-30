using System;
using System.IO;

namespace generator
{
    public class TextSaver
    {
        public static void Save(string text, string fileName)
        {
            string solutionRootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            string folderPath = $"{solutionRootPath}/OutputTexts/";
            using (StreamWriter writer = new StreamWriter(folderPath + fileName, false))
            {
                writer.Write(text);
                writer.Close();
            }
        }
    }
}