using System;


namespace Task3_3_2
{
    public delegate bool CheckStyle(string text);

    class Program
    {
        static void Main(string[] args)
        {
            string ruStr = "Иван";
            string engStr = "Ivan";
            string num = "1998";
            string mixed_1 = "Ivan1";
            string mixed_2 = "Ivan!";
            string mixed_3 = "Ivan Тащит в танках";
            string mixed_4 = "Ivan Tachit";
            string mixed_5 = "IvanТащит";
            string[] wordList = new string[] {
                ruStr, engStr, num, mixed_1, mixed_2, mixed_3, mixed_4, mixed_5
            };

            foreach (var word in wordList)
            {
                Console.WriteLine($"Word is = {word}");
                Console.WriteLine($"   Check is = {"IsRussian",10} == {word.IsRussian()}");
                Console.WriteLine($"   Check is = {"IsEnglish",10} == {word.IsEnglish()}");
                Console.WriteLine($"   Check is = {"IsNumber",10} == {word.IsNumber()}");
                Console.WriteLine($"   Check is = {"IsMixed",10} == {word.IsMixed()}");
                Console.WriteLine("===========================================");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
