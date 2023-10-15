using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.Sprint1.Task6.V14.Lib;

namespace Tyuiu.ShabukovDV.Sprint1.Task6.V14.Test
{
    public class DataServiceTest
    {

        public void TestIsRussianLowercase_ValidString_ReturnsTrue()
        {
            string input = "текст";
            bool result = DataService.IsRussianLowercase(input);
            Assert.IsFalse(result);
        }

        public void TestIsRussianLowercase_InvalidString_ReturnsFalse()
        {
            string input = "Текст";
            bool result = DataService.IsRussianLowercase(input);
            Assert.IsFalse(result);
        }
    }
}
