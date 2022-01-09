using System;
using System.Collections.Generic;

// Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. 
// Сумма этих чисел будет равна 23. 
// Напишите программу, которая выводит на экран сумму всех чисел меньше 1000, кратных 3 или 5.

namespace Task_1_1
{
    class _5_Sum_Of_NumbersClass
    {
        public static void SUM_OF_NUMBERS()
        {
            int sum = 0;
            List<int> lst = new List<int>();
            for (int num = 3; num <= 1000; num++)
            {
                if (num % 3 == 0 || num % 5 == 0)
                {
                    lst.Add(num);
                    sum += num;
                }
            }
            Console.WriteLine("Сумма: {0}", sum);
        }
    }
}
