using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IsaevMA.Sprint2.Task5.V1.Lib;

namespace Tyuiu.IsaevMA.Sprint2.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonth()
        {
            DataService ds = new DataService();

            Assert.AreEqual("31", ds.FindMonth(1));
            Assert.AreEqual("28", ds.FindMonth(2));
            Assert.AreEqual("31", ds.FindMonth(3));
            Assert.AreEqual("30", ds.FindMonth(4));
            Assert.AreEqual("31", ds.FindMonth(5));
            Assert.AreEqual("30", ds.FindMonth(6));
            Assert.AreEqual("31", ds.FindMonth(7));
            Assert.AreEqual("31", ds.FindMonth(8));
            Assert.AreEqual("30", ds.FindMonth(9));
            Assert.AreEqual("31", ds.FindMonth(10));
            Assert.AreEqual("30", ds.FindMonth(11));
            Assert.AreEqual("31", ds.FindMonth(12));


            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonth(0);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonth(13);
            });
        }
    }
}