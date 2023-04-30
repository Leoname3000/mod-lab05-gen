using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using generator;

namespace ProjCharGenerator.Test
{

    [TestClass]
    public class RouletteTests
    {
        int[] weights = new int[] { 8, 5, 3 };

        [TestMethod]
        public void RollTest0()
        {
            Random random = new Random(1);
            int actualIndex = Roulette.Roll(weights, random);
            int expectedIndex = 0;
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void RollTest1()
        {
            Random random = new Random(0);
            int actualIndex = Roulette.Roll(weights, random);
            int expectedIndex = 1;
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void RollTest2()
        {
            Random random = new Random(10);
            int actualIndex = Roulette.Roll(weights, random);
            int expectedIndex = 2;
            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}