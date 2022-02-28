using System;

namespace Task_1_3
{
    public static class Game
    {
        public enum InputOutput
        {
            Input,
            Output
        }

        public static void StartGame()
        {

            PrintMessage("Введите N");
            PrintMessage(messageType: InputOutput.Input);
            int peopleCount = 0;
            if (!int.TryParse(Console.ReadLine(), out peopleCount))
            {
                throw new Exception("Неправильно введено число!");
            }
            CircleList<Human> cList = new CircleList<Human>(HumanGenerator.GenerateHumans(peopleCount));

            PrintMessage("Введите число, какой по счёту человек будет вычеркнут в каждом раунде:");
            PrintMessage(messageType: InputOutput.Input);
            int indexDeleter = 0;
            if (!int.TryParse(Console.ReadLine(), out indexDeleter))
            {
                throw new Exception("Неправильно введено число!");
            }
            RussianRoulette<Human> weakLink = new RussianRoulette<Human>(indexDeleter, cList);
            weakLink.StartWeakestLink();
        }

        public static void PrintMessage(string message = "", InputOutput messageType = InputOutput.Output)
        {
            switch (messageType)
            {
                case InputOutput.Input:
                    Console.Write($"ВВОД: {message}");
                    break;
                case InputOutput.Output:
                    Console.WriteLine($"ВЫВОД: {message}");
                    break;
            }
        }
    }
}
