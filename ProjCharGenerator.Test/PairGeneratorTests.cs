using Microsoft.VisualStudio.TestTools.UnitTesting;
using generator;

namespace ProjCharGenerator.Test;

[TestClass]
public class PairGeneratorTests
{
    private PairGenerator pg = new PairGenerator();
    
    [TestMethod]
    public void GenerateTextTest0()
    {
        string actual = pg.GenerateText(8, 0);
        string expected = "на него то же уже не и что в том и что никто не с ним ";
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void GenerateTextTest1()
    {
        string actual = pg.GenerateText(8, 1);
        string expected = "в этом я не так как уже не и даже но и так и что вы ";
        Assert.AreEqual(expected, actual);
    }
}