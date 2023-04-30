using Microsoft.VisualStudio.TestTools.UnitTesting;
using generator;

namespace ProjCharGenerator.Test;

[TestClass]
public class BigramGeneratorTests
{
    private BigramGenerator bg = new BigramGenerator();
    
    [TestMethod]
    public void GenerateTextTest0()
    {
        string actual = bg.GenerateText(16, 0);
        string expected = "астрненылязамоку";
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void GenerateTextTest1()
    {
        string actual = bg.GenerateText(16, 1);
        string expected = "бидитоймыгобийши";
        Assert.AreEqual(expected, actual);
    }
}