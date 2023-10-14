using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.Sprint1.Task1.V0.Lib;

//Задание
//Написать программу, которая запрашивает у пользователя исходные данные,
//Вычисляет результат по формуле x / ( y - 1 ) и печатает его на экране.

namespace Tyuiu.ShabukovDV.Sprint1.Task1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Шабуокв Д. В. | СМАРТб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задания #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Шабуков Данил Валерьевич | СмартБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* вычисляет результат по формуле x / ( y - 1) и печатает на экране.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            //Метод Calculate находится в библеотеке Tyuiu.ShabukovDV.Sprint1.Task1.V0.Lib
            //В классе DataService

            Console.ReadLine();

        }
    }
}
