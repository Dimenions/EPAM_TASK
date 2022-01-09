using System;

namespace Task_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentCommand = "";
            while (currentCommand != "0")
            {
                Console.Clear();
                Console.WriteLine(
                    @"Введите комманду : 
    1: Rectangle
    2: Triangle
    3: AnotherTriangle
    4: XMAS_TREE
    5: SUM_OF_NUMBERS
    6: FONT_ADJUSTMENT
    7: ARRAY_PROCESSING
    8: NO_POSITIVE
    9: NON_NEGATIVE_SUM
    10: 2D_ARRAY
    0: Exit
"
);
                currentCommand = Console.ReadLine();
                switch (currentCommand)
                {
                    case "1":
                        _1_RectangleClass.Rectangle();
                        break;
                    case "2":
                        _2_TriangleClass.Triangle();
                        break;
                    case "3":
                        _3_AnotherTriangleClass.AnotherTriangle();
                        break;
                    case "4":
                        _4_Xmas_TreeClass.XMAS_TREE();
                        break;
                    case "5":
                        _5_Sum_Of_NumbersClass.SUM_OF_NUMBERS();
                        break;
                    case "6":
                        _6_Font_AdjustmentClass.FONT_ADJUSTMENT();
                        break;
                    case "7":
                        _7_Array_ProcessingClass.ARRAY_PROCESSING();
                        break;
                    case "8":
                        _8_No_PositiveClass.NO_POSITIVE();
                        break;
                    case "9":
                        _9_Non_Negative_SumClass.NON_NEGATIVE_SUM();
                        break;
                    case "10":
                        _10_2d_ArreyClass._2D_ARRAY();
                        break;

                    case "0":
                        currentCommand = "0";
                        break;
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
