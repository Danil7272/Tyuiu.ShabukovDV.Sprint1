using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.Sprint1.Task6.V14.Lib;

namespace Tyuiu.ShabukovDV.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();

            bool isRussianLowercase = IsRussianLowercase(input);
            Console.WriteLine("Строка состоит только из строчных русских букв: " + isRussianLowercase);
        }

        static bool IsRussianLowercase(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLower(c) || !IsRussianLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsRussianLetter(char c)
        {
            return c >= 'а' && c <= 'я';
        }
    }     }    
