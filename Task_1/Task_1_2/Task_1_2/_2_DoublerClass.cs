using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    Напишите программу, которая удваивает в первой введённой строке 
все символы, принадлежащие второй введённой строке.
*/

namespace Task_1_2
{
    class _2_DoublerClass
    {
        public static void Doubler()
        {
            Console.WriteLine("Введите строку, в которой будут удваиваться символы: ");
            string strToDouble = Console.ReadLine();

            Console.WriteLine("Введите строку, c помощью которой будут удваиваться символы: ");
            string strSymbolsDouble = Console.ReadLine();

            List<char> symbols = strSymbolsDouble.Select(x => x).Distinct().ToList();

            StringBuilder doublString = new StringBuilder();
            for (int i = 0; i < strToDouble.Length; i++)
            {
                if (symbols.Contains(strToDouble[i]))
                {
                    doublString.Append(strToDouble[i]);
                    doublString.Append(strToDouble[i]);
                }
                else
                {
                    doublString.Append(strToDouble[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Итоговая строка: ");
            Console.WriteLine(doublString);
        }
    }
}
