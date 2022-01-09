using System;

/*
 Написать программу, которая запрашивает с клавиатуры число N 
 и выводит на экран следующее «изображение», состоящее из N треугольников:
 Пример 3:

        *
        * 
       ***
        *
       ***
      ***** 
        *
       ***
      *****
     ******* 
     * 
    */

namespace Task_1_1
{
    class _4_Xmas_TreeClass
    {
        public static void XMAS_TREE()
        {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            Console.Clear();

            // Количество частей ёлки
            for (int k = N; k >= 0; k--)
            {
                // Цикл для N-k строк дерева
                for (int i = 0; i < N - k; i++)
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
}
