using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.isaevma.sprint2.task3.v6.lib;

namespace tyuiu.isaevma.sprint2.task3.v6.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = 0.64;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -40;
            double res = ds.Calculate(x);
            double wait = -439.975;
            Assert.AreEqual(wait, res);
        }
    }
}
