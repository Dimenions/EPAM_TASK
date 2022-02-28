using System;

namespace Task_3_1_2
{
    public static class TextAnalizatorHandler
    {
        public enum InputOutput
        {
            Input,
            Output
        }

        public static void Start(string text)
        {
            TextAnalizator analizator = new TextAnalizator(text);

            MenuHandler(analizator);
        }

        public static void MenuHandler(TextAnalizator analizator)
        {
            bool isWorking = true;
            while (isWorking)
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine(@"
1: Вывести все уникальные слова
2: Вывести слова и их количество, с которым они появляются в тексте
3: Вывести частоту появления слов в тексте, относительно всех слов
0: Выйти из программы");

                PrintMessage(messageType: InputOutput.Input);
                string command = Console.ReadLine();
                Console.Clear();
                switch (command.Trim())
                {
                    case "1":
                        PrintMessage("Вы выбрали: \"Вывести все уникальные слова\"");
                        analizator.PrintUniqueWords();
                        break;
                    case "2":
                        PrintMessage("Вы выбрали: \"Вывести слова и их количество в тексте\"");
                        analizator.PrintWordCount();
                        break;
                    case "3":
                        PrintMessage("Вы выбрали: \"Вывести частоту появления слов в тексте, относительно всех слов\"");
                        analizator.PrintWordFrequencyFromAllWords();
                        break;
                    case "0":
                        isWorking = false;
                        continue;
                    default:
                        PrintMessage("Команда введена не верно");
                        break;
                }
                PrintMessage("Нажмите любую кнопку, чтобы очистить экран и вернуться в меню");
                Console.ReadKey();
            }
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
