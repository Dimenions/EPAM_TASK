using System;

// Написать программу, которая заменяет все положительные элементы в трёхмерном массиве на нули. 
// Число элементов в массиве и их тип определяются разработчиком.

namespace Task_1_1
{
    class _8_No_PositiveClass
    {
        public static void NO_POSITIVE()
        {
            Random rnd = new Random(42);

            int[,,] thirdMass = new int[5, 5, 5];

            // Заполнение 3d массива
            for (int i = 0; i < thirdMass.GetLength(0); i++)
            {
                for (int j = 0; j < thirdMass.GetLength(1); j++)
                {
                    for (int z = 0; z < thirdMass.GetLength(2); z++)
                    {
                        thirdMass[i, j, z] = rnd.Next(-5, 5);
                    }
                }
            }

            Console.WriteLine("До изменения:");
            PrintMass(thirdMass);

            // Замена положительных элементов на 0
            for (int i = 0; i < thirdMass.GetLength(0); i++)
            {
                for (int j = 0; j < thirdMass.GetLength(1); j++)
                {
                    for (int z = 0; z < thirdMass.GetLength(2); z++)
                    {
                        if (thirdMass[i, j, z] > 0)
                        {
                            thirdMass[i, j, z] = 0;
                        }
                    }
                }
            }

            Console.WriteLine("После изменения:");
            PrintMass(thirdMass);
        }


        //Функция вывода
        static void PrintMass(int[,,] Mass)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Массив уровень {0}: \n", i);
                for (int j = 0; j < 3; j++)
                {
                    for (int d = 0; d < 3; d++)
                    {
                        Console.Write(Mass[i, j, d]);
                        Console.Write(",");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine();
            }
        }
        
    }
}
