using System;

/*
 Написать программу, которая запрашивает с клавиатуры число N и выводит 
 на экран следующее «изображение», состоящее из N строк:
 Пример 5:
 *
 **
 ***
 ****
 *****
*/
namespace Task_1_1
{
    class _2_TriangleClass
    {
        public static void Triangle()
        {
            Console.WriteLine("Введите N");
            int N = 0;
            int.TryParse(Console.ReadLine(), out N);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
