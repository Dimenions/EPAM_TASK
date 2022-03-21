using System;
using DynamicArray;
using CycledDynamicArray;

namespace Task_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests();
            Console.WriteLine("===================================");
            Console.WriteLine("TestsOfCycledArray");
            TestsOfCycledArray();
            Console.ReadKey();
        }

        static void Tests()
        {
            DynamicArray<int> test = new DynamicArray<int>();

            Console.WriteLine("===================================");
            Console.WriteLine("Добавление множества элементов");
            test.AddRange(new int[] { 7, 9, 4, 3, 2 });

            Console.WriteLine("===================================");
            Console.WriteLine("Удаление и вставка элементов");
            test.Remove(2);
            test.RemoveAt(2);
            test.Insert(9, 3);
            test.Insert(23, 2);
            test.Insert(45, 4);

            test.PrintAll();
            Console.WriteLine();

            Console.WriteLine("===================================");
            Console.WriteLine("Проверка Capacity при увеличении количества элементов");
            for (int i = 0; i < 6; i++)
            {
                test.Add(i);
                Console.WriteLine($"Capacity = {test.Capacity}, Length = {test.Length}");
            }

            Console.WriteLine("===================================");
            Console.WriteLine("Добавление ещё бОльшего количества чисел и вывод на экран");
            test.AddRange(new int[] { -555, 7, 9, 8, 1, 15, 26, 8, 9, 10 });
            test.PrintAll();


            Console.WriteLine("===================================");
            Console.WriteLine("Проверка ToArray()");
            var clonnedArr = test.ToArray();
            Console.WriteLine("====================\n====================\n====================");
            for (int i = 0; i < clonnedArr.Length; i++)
            {
                Console.WriteLine($"[{i}] = {clonnedArr[i]}");
            }

            for (int i = 0; i < test.Length; i++)
            {
                test[i] = -11;
            }
            Console.WriteLine("=====================");
            test.PrintAll();

            Console.WriteLine("====================\n====================\n====================");
            for (int i = 0; i < clonnedArr.Length; i++)
            {
                Console.WriteLine($"[{i}] = {clonnedArr[i]}");
            }
            

            Console.WriteLine("===================================");
            Console.WriteLine("Проверка уменьшения Capacity");
            for (int i = 0; i < 32; i++)
            {
                test.Capacity = 32 - i;
                test.PrintAll();
                Console.WriteLine("==================================");
            }
            test.Capacity = 500;

            Console.WriteLine("===================================");
            Console.WriteLine("Обратный и обычный индекс");
            for (int i = -test.Length; i < test.Length; i++)
            {
                Console.WriteLine($"[{i}] = {test[i]}");
            }
            Console.WriteLine();

            test.PrintAll();
        }

        static void TestsOfCycledArray()
        {
            CycledDynamicArray<int> test = new CycledDynamicArray<int>();
            //DynamicArray<int> test = new DynamicArray<int>();
            test.AddRange(new int[] { 7, 9, 4, 3, 2 });

            int pos = 0;
            foreach (var item in test)
            {
                if (pos % test.Length == 0)
                {
                    Console.WriteLine("=========================================");
                }
                Console.WriteLine($"[{pos++}] = {item}");
                Console.ReadKey();
            }
        }
    }
}
