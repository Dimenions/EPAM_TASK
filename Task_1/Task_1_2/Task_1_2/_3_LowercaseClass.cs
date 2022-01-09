using System;

/*
    Напишите программу, которая считает количество слов, начинающихся с маленькой буквы. 
Предлоги, союзы и междометия считаются словами. 
Финальную точку в предложении (как и любой другой знак) можно не учитывать.
Вариант без * - разделителем между словами считать ТОЛЬКО пробелы
Вариант со * - разделители между словами могут быть любые: запятые, двоеточия, точки с запятой.
 */

namespace Task_1_2
{
    class _3_LowercaseClass
    {
        public static void Lowercase()
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            string[] words = str.Trim().Split(new char[] { ';', ':', '!', ',', '.', '?', ' ' },
                                                        StringSplitOptions.RemoveEmptyEntries);
            int countOfWordsPerSmallLetter = 0;
            foreach (var word in words)
            {
                if (Char.IsLower(word[0]) == true)
                    countOfWordsPerSmallLetter += 1;
            }

            Console.WriteLine();
            Console.WriteLine("Количество слов, начинающихся с маленькой буквы: ");
            Console.WriteLine(countOfWordsPerSmallLetter);
        }
    }
}
