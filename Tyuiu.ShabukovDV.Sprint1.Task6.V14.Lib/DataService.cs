using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShabukovDV.Sprint1.Task6.V14.Lib
{
    public class DataService
    {
        public static bool IsRussianLowercase(string input)
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

        private static bool IsRussianLetter(char c)
        {
            return c >= 'а' && c <= 'я';
        }
    }
}
}
