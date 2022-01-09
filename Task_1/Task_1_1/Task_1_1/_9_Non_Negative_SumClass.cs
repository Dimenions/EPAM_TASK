using System;
using System.Collections.Generic;
using System.Linq;

// Написать программу, которая определяет сумму неотрицательных элементов в одномерном массиве. 
// Число элементов в массиве и их тип определяются разработчиком.

namespace Task_1_1
{
    class _9_Non_Negative_SumClass
    {
        public static void NON_NEGATIVE_SUM()
        {
            List<int> arr = new List<int>();
            Random rnd = new Random(10);

            for (int i = 0; i < 100; i++)
            {
                arr.Add(rnd.Next(-10, 10));
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Сумма положительных чисел = " + arr.Where(x => x > 0).Sum());
        }
    }
}
