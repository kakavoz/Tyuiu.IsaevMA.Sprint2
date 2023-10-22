using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IsaevMA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.IsaevMA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonth()
        {
            DataService ds = new DataService();

            Assert.AreEqual("31", ds.FindDateOfNextDay(1));



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
