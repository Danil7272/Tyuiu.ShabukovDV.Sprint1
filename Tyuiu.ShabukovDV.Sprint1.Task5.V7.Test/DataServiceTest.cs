using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ShabukovDV.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.AngleToHoursMinutes(100);

            Assert.AreEqual(3, res);
        }
    }
}
