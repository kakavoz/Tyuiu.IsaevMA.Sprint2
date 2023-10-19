using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.isaevma.sprint2.v23.lib;

namespace tyuiu.isaevma.sprint2.v23.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOprations()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 795;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, true, true, false, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
