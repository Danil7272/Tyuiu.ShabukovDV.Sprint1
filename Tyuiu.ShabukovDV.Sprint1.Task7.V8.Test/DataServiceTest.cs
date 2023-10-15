using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint1.Task7.V8.Lib;

namespace Tyuiu.ShabukovDV.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2, 2);
            Assert.AreEqual(-0.107, res);
        }
    }
}
