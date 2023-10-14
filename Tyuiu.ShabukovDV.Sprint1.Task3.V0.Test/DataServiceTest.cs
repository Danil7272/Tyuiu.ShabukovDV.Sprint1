using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShabukovDV.Sprint1.Task3.V0.Lib;
using Tyuiu.ShabukovDV.Sprint1.Task3.V14.Lib;

namespace Tyuiu.ShabukovDV.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.ReverseNumber(123);


            Assert.AreEqual(res, 321);
        }
    }
}
