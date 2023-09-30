using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShabukovDV.Sprint1.Task0.V0.Lib;

//Задание
//НАписать программу, которая вычисляет выражение 10 / (2 + 3) и печатает результат на экране 

namespace Tyuiu.ShabukovDV.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт 0 | Выполнил: Шабуков Д. В. | СмартБ-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задания #0                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Шабуков Данил Валерьевич | СмартБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет 10 / (2 + 3)                      *");
            Console.WriteLine("* и печатает на экране.                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 10 / (2 + 3)                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            //Метод Calculate находится в библеотеке Tyuiu.ShabukovDV.Sprint1.Task0.V0.Lib
            //в классе DataService
            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}
