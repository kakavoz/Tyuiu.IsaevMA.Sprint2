using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.isaevma.sprint2.task1.v27.lib;


namespace tyuiu.isaevma.sprint2.task1.v27.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 654;
            int b = 325;
            int c = 154;
            int d = 333;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}