using Microsoft.VisualStudio.TestTools.UnitTesting;
using generator;

namespace ProjCharGenerator.Test
{

    [TestClass]
    public class TextSaverTest
    {
        [TestMethod]
        public void SaveTest()
        {
            TextSaver.Save("Sample Text", "TestText.txt");

            string actual;
            string solutionRootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            string folderPath = $"{solutionRootPath}/OutputTexts/";
            using (StreamReader reader = new StreamReader(folderPath + "TestText.txt"))
            {
                actual = reader.ReadToEnd();
                reader.Close();
            }

            string expected = "Sample Text";
            Assert.AreEqual(expected, actual);
        }
    }
}