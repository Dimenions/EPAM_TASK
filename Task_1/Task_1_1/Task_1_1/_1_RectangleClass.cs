using System;

// Написать программу, которая определяет площадь прямоугольника со сторонами a и b. 
// Если пользователь вводит некорректные значения (отрицательные или ноль), 
// должно выдаваться сообщение об ошибке. 
// Возможность ввода пользователем строки вида «абвгд» или нецелых чисел игнорировать.

namespace Task_1_1
{
    class _1_RectangleClass
    {
        public static void Rectangle()
        {
            Console.Write("Введите сторону a = ");
            int a = Rectangle_Validator(Console.ReadLine());
            if (a == -1)
            {
                return;
            }

            Console.Write("Введите сторону b = ");
            int b = Rectangle_Validator(Console.ReadLine());
            if (b == -1)
            {
                return;
            }
            Console.WriteLine($"Площадь прямоугольника со сторонами {a} и {b} равна {a * b}");
        }


        static int Rectangle_Validator(string strNum)
        {
            int num = 0;

            if (int.TryParse(strNum, out num) == false)
            {
                Console.WriteLine("Ошибка! Введено некорректное значение!");
                return -1;
            }
            else if (num <= 0)
            {
                Console.WriteLine("Ошибка! Число должно быть больше нуля!");
                return -1;
            }

            return num;
        }
    }
}
