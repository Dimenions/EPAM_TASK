using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    public class Console
    {
        public delegate int MyExtensionDelegate(IEnumerable<int> source);
        public delegate int EveryElementDelegate(int firstElement, int secondElement);

        int[] arrExample_1 = new int[] {
            5, 7, 1, 2, 3, 8, 9, 3, 1, 0, 1, 2, 1254, 21,
            421, 124, 12, 214, 214, 561, 7, 567, 70, 0, 0, 0
        };
        
        int[] arrExample_2 = new int[] { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 0, 0, 1, 2, 3, };

        int[] choosedArray;

        public void StartShow()
        {
            while (true)
            {
                System.Console.Clear();
                System.Console.WriteLine("Выбери тестовый массив:");
                System.Console.WriteLine($"1 : {string.Join(" ", arrExample_1)}");
                System.Console.WriteLine($"2 : {string.Join(" ", arrExample_2)}");

                string command = System.Console.ReadLine().Trim();
                switch (command)
                {
                    case "1":
                        choosedArray = arrExample_1;
                        break;
                    case "2":
                        choosedArray = arrExample_2;
                        break;
                    case "0":
                        return;
                    default:
                        continue;
                }
                TaskMenu();
            }
        }

        void DoActionsWithElements(int[] array, EveryElementDelegate function, int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = function.Invoke(array[i], num);
            }
        }

        void TaskMenu()
        {
            while (true)
            {
                System.Console.Clear();
                System.Console.WriteLine("Исходный массив :");
                System.Console.WriteLine($"[{string.Join(" ", choosedArray)}]");
                System.Console.WriteLine();

                System.Console.WriteLine(
                    @"Выберите какое из заданий хотите проверить:
    1 : Delegates
    2 : Extensions
    0 : Вернуться назад");

                switch (System.Console.ReadLine().Trim())
                {
                    case "1":
                        DelegateTaskMenu();
                        break;
                    case "2":
                        ExtensionsMenu();
                        break;
                    case "0":
                        return;
                    default:
                        continue;
                }
            }
        }

        void ExtensionsMenu()
        {
            while (true)
            {
                var justToShowOnCopy = choosedArray.ToArray();
                System.Console.Clear();

                System.Console.WriteLine("Исходный массив :");
                System.Console.WriteLine($"[{string.Join(" ", choosedArray)}]");
                System.Console.WriteLine();

                System.Console.WriteLine(
                    @"Выберите какое из заданий хотите проверить:
    1 : Сумма
    2 : Среднее значение
    3 : Первый найденный элемент с наибольшим количеством вхождений
    4 : Частота всех элементов
    0 : Вернуться назад");

                switch (System.Console.ReadLine().Trim())
                {
                    case "1":
                        System.Console.WriteLine(justToShowOnCopy.MySum());
                        break;
                    case "2":
                        System.Console.WriteLine(justToShowOnCopy.MyAverage());
                        break;
                    case "3":
                        System.Console.WriteLine(justToShowOnCopy.MyMostCountedElement());
                        break;
                    case "4":
                        foreach (var item in justToShowOnCopy.MyElementFrequency())
                        {
                            System.Console.WriteLine($"[{item.Key} = {item.Value}]");
                        }
                        break;
                    case "0":
                        return;
                    default:
                        continue;
                }

                System.Console.WriteLine("Нажми на любую кнопку, чтобы продолжить");
                System.Console.ReadKey();
            }
        }

        void DelegateTaskMenu()
        {
            while (true)
            {
                var justToShowOnCopy = choosedArray.ToArray();
                System.Console.Clear();

                System.Console.WriteLine("Исходный массив :");
                System.Console.WriteLine($"[{string.Join(" ", choosedArray)}]");
                System.Console.WriteLine();

                System.Console.WriteLine(
                    @"Выберите какое из заданий хотите проверить:
    1 : FloorDivide на 2
    2 : Multiply на 2 
    3 : Power в 2
    0 : Вернуться назад");

                switch (System.Console.ReadLine().Trim())
                {
                    case "1":
                        DoActionsWithElements(justToShowOnCopy, new EveryElementDelegate(MyDelegates.FloorDivide), 2);
                        System.Console.WriteLine(string.Join(" ", justToShowOnCopy));
                        break;
                    case "2":
                        DoActionsWithElements(justToShowOnCopy, new EveryElementDelegate(MyDelegates.Multiply), 2);
                        System.Console.WriteLine(string.Join(" ", justToShowOnCopy));
                        break;
                    case "3":
                        DoActionsWithElements(justToShowOnCopy, new EveryElementDelegate(MyDelegates.Power), 2);
                        System.Console.WriteLine(string.Join(" ", justToShowOnCopy));
                        break;
                    case "0":
                        return;
                    default:
                        continue;
                }

                System.Console.WriteLine("Нажми на любую кнопку, чтобы продолжить");
                System.Console.ReadKey();
            }
        }
    }
}
