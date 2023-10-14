using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint1.Task2.V0.Lib;

namespace Tyuiu.ShabukovDV.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertKmToMetre(x);
            Assert.AreEqual(4, res);
        }
    }
}
