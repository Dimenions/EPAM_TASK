using System;

/*
    Напишите программу, которая определяет среднюю длину слова во введённой текстовой строке.
Учтите, что символы пунктуации на длину слов влиять не должны. 
Не стоит искать каждый символ-разделитель вручную: пожалейте своё время и используйте стандартные 
методы классов String и Char.
Регулярные выражения не использовать.
В случае дробного результата (х.5) – можете как оставить его таким, так и округлить. 
Стоит оставить комментарий в коде, указывающий, какое решение вы приняли.
 */

namespace Task_1_2
{
    class _1_AveragesClass
    {
        public static void Averages()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            char[] splitters = new char[] { ';', ':', '!', ',', '.', '?', ' '};
            string[] words = str.Trim().Split(splitters, StringSplitOptions.RemoveEmptyEntries);

            int charsCount = 0;
            foreach (var word in words)
            {
                charsCount += word.Length;
            }

            double averageWordLenght = (double)charsCount / words.Length;

            //Я брал не огругляя знгачения (по заданию)
            Console.WriteLine($"Сумма символов = {charsCount}");
            Console.WriteLine($"Количество слов =  {words.Length}");
            Console.WriteLine($"Средняя длина слова {averageWordLenght} ");
        }
    }
}
