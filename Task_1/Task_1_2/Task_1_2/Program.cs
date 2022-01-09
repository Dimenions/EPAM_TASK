using System;

namespace Task_1_2
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
    1: Averages
    2: Doubler
    3: Lowercase
    4: Validator
    0: Exit
"
);
                currentCommand = Console.ReadLine();
                switch (currentCommand)
                {
                    case "1":
                        _1_AveragesClass.Averages();
                        break;
                    case "2":
                        _2_DoublerClass.Doubler();
                        break;
                    case "3":
                        _3_LowercaseClass.Lowercase();
                        break;
                    case "4":
                        _4_ValidatorClass.Validator();
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
