using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ShabukovDV.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите на сколько градусов повернулась стрелка: ");
            double f;
            f = double.Parse(Console.ReadLine());
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Солиев А. Х. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Шабуков Данил Валерьевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того*");
            Console.WriteLine("* момента (в первой половине дня), когда часовая стрелка повернулась на   *");
            Console.WriteLine("* f градусов (0<f<360, f – вещественное число).,                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(f);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.AngleToHoursMinutes(f);
            Console.WriteLine(res);


            Console.ReadKey();

        }
    }
}
