using Microsoft.VisualStudio.TestTools.UnitTesting;
using generator;

namespace ProjCharGenerator.Test;

[TestClass]
public class WordGeneratorTests
{
    private WordGenerator wg = new WordGenerator();
    
    [TestMethod]
    public void GenerateTextTest0()
    {
        string actual = wg.GenerateText(8, 0);
        string expected = "мне вот они это в это него он ";
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void GenerateTextTest1()
    {
        string actual = wg.GenerateText(8, 1);
        string expected = "не и как они так а что раз ";
        Assert.AreEqual(expected, actual);
    }
}