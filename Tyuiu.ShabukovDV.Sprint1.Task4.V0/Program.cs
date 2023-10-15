using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.Sprint1.Task4.V0.Lib;

namespace Tyuiu.ShabukovDV.Sprint1.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("1 / (x ^ 2 + y ^ 2) = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
