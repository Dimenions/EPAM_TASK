using System;

/*
    Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее 
«изображение», состоящее из N строк:
Пример 4:
            *
           ***
          *****
         *******
*/

namespace Task_1_1
{
    class _3_AnotherTriangleClass
    {
        public static void AnotherTriangle()
        {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            Console.Clear();

            // Цикл для N строк дерева
            for (int i = 0; i < N; i++)
            {
                // Цикл для пробелов слева от дерева
                for (int j = 0; j < N - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // Цикл для левой части дерева
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }

                // Цикл для правой части дерева
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
