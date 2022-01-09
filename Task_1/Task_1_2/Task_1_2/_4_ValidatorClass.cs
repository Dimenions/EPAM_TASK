using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
    Напишите программу, которая заменяет первую букву первого слова в предложении на заглавную.
В качестве окончания предложения можете считать только «.|?|!».
Многоточие и «?!» можете опустить.
 */

namespace Task_1_2
{
    class _4_ValidatorClass
    {
        public static void Validator()
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            string regex = "([ а-яА-Я,:;]+[.|!|?])";
            List<string> listSentences = new List<string>();

            foreach (Match match in Regex.Matches(str, regex, RegexOptions.IgnoreCase))
            {
                listSentences.Add(match.Value.Trim());
            }

            for (int i = 0; i < listSentences.Count; ++i)
            {
                listSentences[i] = Char.ToUpper(listSentences[i][0]) + listSentences[i].Substring(1);
            }
            Console.WriteLine("Исправленое предложения: ");
            Console.WriteLine(string.Join(" ", listSentences));
        }
    }
}
