using System;
using System.Collections.Generic;

// Написать программу, которая генерирует случайным образом элементы массива 
// (число элементов в массиве и их тип определяются разработчиком), 
// определяет для него максимальное и минимальное значения, сортирует 
// массив и выводит полученный результат на экран.
//
// Примечание: LINQ запросы и готовые функции языка(Sort, Max и т.д.) 
// использовать в данном задании запрещается.

namespace Task_1_1
{
    class _7_Array_ProcessingClass
    {
        public static void ARRAY_PROCESSING()
        {
            List<int> arr = new List<int>();
            // Генератор псевдослучайных величин так как нельзя использовать встроенные функции языка
            for (int i = 0; i < 30; i++)
            {
                int a = 43;
                int c = 28;
                int m = 235;
                int seed = i * 5;
                seed = (a * seed + c) % m;

                if (arr.Contains(seed) == false)
                {
                    arr.Add(seed);
                }
                else
                {
                    seed = (a * (seed * 15) % 31 + c) % m * 1000;
                    arr.Add(seed);
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            // Min/Max Values
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }

            // Сортировка
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = i; j < arr.Count; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            // Вывод
            Console.WriteLine();
            Console.WriteLine("Максимум: {0} Минимум: {1}", maxValue, minValue);
            Console.WriteLine();
            Console.WriteLine("Sorted:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
