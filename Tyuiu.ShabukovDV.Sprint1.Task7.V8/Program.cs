using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.Sprint1.Task7.V8.Lib;

namespace Tyuiu.ShabukovDV.Sprint1.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x, y через enter: ");
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шабуков Д. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Шабуков Данил Валерьвич | СМАРТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до   *");
            Console.WriteLine("* 3 знаков после запятой.                                                 *");
            Console.WriteLine("* Формула: z=ln|(y-sqrt(abc(x)))(x-y/x+(x^2/4))                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(x + " " + y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.Calculate(x, y);
            Console.WriteLine(Math.Round(res, 3));


            Console.ReadKey();
        }
    }
}
