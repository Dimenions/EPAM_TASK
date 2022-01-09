using System;
using System.Collections.Generic;
using System.Linq;


// Для форматирования текста надписи можно использовать различные начертания:
// полужирное, курсивное и подчёркнутое, а также их сочетания.
// Предложите способ хранения информации о форматировании текста надписи и напишите программу,
// которая позволяет устанавливать и изменять начертание:

namespace Task_1_1
{
    class _6_Font_AdjustmentClass
    {
        public static void FONT_ADJUSTMENT()
        {
            Dictionary<string, bool> fontSettings = new Dictionary<string, bool>();

            fontSettings.Add("Bold", false);
            fontSettings.Add("Italic", false);
            fontSettings.Add("Underline", false);

            string currentCommand = "";
            while (currentCommand != "0")
            {
                Console.Write("Параметры надписи: ");

                // Выбираем активные из словаря для вывода
                var activeSettings = fontSettings.Where(x => x.Value == true).Select(x => x.Key).ToList();
                if (activeSettings.Count != 0)
                {
                    foreach (var setting in activeSettings)
                    {
                        Console.Write($"{setting} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("None");
                }

                Console.WriteLine(
                    $@"Введите:
        1: bold
        2: italic
        3: underline
        0: exit"
                );

                // Меню выбора
                currentCommand = Console.ReadLine();
                switch (currentCommand)
                {
                    case "1":
                        fontSettings["Bold"] = fontSettings["Bold"] ? false : true;
                        break;

                    case "2":
                        fontSettings["Italic"] = fontSettings["Italic"] ? false : true;
                        break;

                    case "3":
                        fontSettings["Underline"] = fontSettings["Underline"] ? false : true;
                        break;

                    default:
                        break;
                }

                if (currentCommand == "0")
                {
                    break;
                }
            }
        }
    }
}
