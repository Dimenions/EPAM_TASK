using System;

// Элемент двумерного массива считается стоящим на чётной позиции, если сумма
// номеров его позиций по обеим размерностям является чётным числом 
// (например, [1,1] — чётная позиция, а [1,2] — нет). 
// Определить сумму элементов массива, стоящих на чётных позициях.

namespace Task_1_1
{
    class _10_2d_ArreyClass
    {
        public static void _2D_ARRAY()
        {
            int[,] arr = new int[5, 5];
            Random rnd = new Random(5);

            // Случайное заполнение
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(10);
                }
            }

            // Вывод
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Подсчитывание суммы
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            Console.WriteLine("Сумма элементов на чётных позициях = " + sum);
        }
    }
}
