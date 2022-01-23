using System;
using CustomStringsClass;

namespace Task_1_1_CustomString
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] arr = new char[] { 'T', 'I', 'G', 'E', 'R', ' ', 'N', 'o', 'r', 'm', '?'};
            CustomString customString = new CustomString(arr);
            Console.WriteLine($"Начальная строка: {Environment.NewLine}");
            Console.WriteLine($"{customString} {Environment.NewLine}");


            customString = customString.Insert(2, 'X');
            Console.WriteLine($"Демонстрация вставки (2 индекс 'X'): {Environment.NewLine}");
            Console.WriteLine($"{customString} {Environment.NewLine}");


            customString = customString.Remove(2);
            Console.WriteLine($"Демонстрация удаления (2 индекс 'X'): {Environment.NewLine}");
            Console.WriteLine($"{customString} {Environment.NewLine}");


            Console.WriteLine($"Демонстрация индексатора: {Environment.NewLine}");
            for (int i = 0; i < customString.Length; i++)
            {
                Console.WriteLine($"{customString[i]} {Environment.NewLine}");
            }
            Console.WriteLine();

            Console.WriteLine($"Демонстрация найденного символа: {Environment.NewLine}");
            char temp = 'N';
            Console.WriteLine($"{customString.SearchLine(temp)} {Environment.NewLine}");
            if (temp == customString.SearchLine(temp))
            {
                Console.WriteLine( $"Символ найден верно {Environment.NewLine}");
            }
            else
            {
                Console.WriteLine($"Ошибка!{Environment.NewLine}");
            }

            Console.WriteLine($"Демонстрация преобразования в Массив char: {Environment.NewLine}");
            foreach (var item in customString.ToArray())
            {
                Console.Write(item + "|");
            }
            Console.WriteLine();

            Console.WriteLine($"Демонстрация конкатенации: {Environment.NewLine}");
            CustomString addString = new CustomString(new char[] { 'Y', 'e', 's', '!' });
            Console.WriteLine($"{addString + customString} {Environment.NewLine}");

            // Демонстрация сравнения
            Console.WriteLine($"Демонстрация сравнения: {Environment.NewLine}");
            Console.WriteLine($"{addString == customString} {Environment.NewLine}");

            CustomString copyString = new CustomString(new char[] { 'T', 'I', 'G', 'E', 'R', ' ', 'N', 'o', 'r', 'm', '?' });
            Console.WriteLine(copyString == customString);

            Console.ReadKey();
        }
    }
}
