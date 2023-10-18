using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.isaevma.sprint2.task2.v17.lib;

namespace tyuiu.isaevma.sprint2.task2.v17.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
