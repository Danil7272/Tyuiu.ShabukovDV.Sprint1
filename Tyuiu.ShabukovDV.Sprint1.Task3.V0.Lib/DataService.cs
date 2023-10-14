using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.ShabukovDV.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            double res = 123;
            int num1, num2, num3;
            num1 = 123 % 10;
            num2 = 123 % 100 / 10;
            num3 = 123 / 100;

            res = num1 * 100 + num2 * 10 + num3;

            return res;

        }
    }
}
