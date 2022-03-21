using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace _4_1_FileManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggingStateUpdate loggingState = new LoggingStateUpdate();
            RestoreBackupedFiles restoreBackupedFiles = new RestoreBackupedFiles();

            Thread stateCheckerThread = new Thread(loggingState.StartLogging);
            stateCheckerThread.Name = "FileRecovery";
            stateCheckerThread.Start();

            Thread addLineToAllFilesThread = new Thread(() => loggingState.AddLineToAllFiles(30));

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Хотите ли вы запустить восстановление файлов?");
                Console.WriteLine("1: Да");
                Console.WriteLine("2: Обновить список отслеживаемых файлов");
                Console.WriteLine("3: Запустить добавление одной строки во все файлы каждые 30 секунд(только для отладки)");
                Console.WriteLine("4: Приостановить поток добавления строк во все файлы(только для отладки)");
                Console.WriteLine("0: Завершить программу");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        restoreBackupedFiles.StartRestoring(GetDateTime());
                        break;
                    case "2":
                        // Мы можем обновить список потому что поток разделяет ресуры с основным
                        loggingState.UpdateListOfFiles();
                        break;
                    case "3":
                        addLineToAllFilesThread.Start();
                        break;
                    case "4":
                        addLineToAllFilesThread.Abort();
                        break;
                    case "0":
                        stateCheckerThread.Abort();
                        addLineToAllFilesThread.Abort();
                        return;
                }
                Console.ReadKey();
            }
            //DateTime dateTime = DateTime.Parse("23.04.2021 22:00:32");
        }

        static DateTime GetDateTime()
        {
            DateTime parsedDatetime;
            while (true)
            {
                Console.WriteLine("Введите дату в формате dd.mm.yyyy hh:mm:ss");
                Console.Write("Ввод: ");
                string userString = Console.ReadLine();
                if (DateTime.TryParse(userString, out parsedDatetime) != false)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine("Введённое значение не распознано! Введите значение заново:");
            }

            return parsedDatetime;
        }
    }
}
