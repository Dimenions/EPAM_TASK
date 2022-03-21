using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_CustomPaint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВЫВОД: Введите имя пользователя");
            Console.Write("ВВОД: ");
            User currentUser = new User()
            {
                Name = Console.ReadLine()
            };

            PaintHandler paintHandler = new PaintHandler(currentUser);

            string currentCommand = "";
            while (currentCommand != "0")
            {
                Console.Clear();
                Console.WriteLine(
                    $@"Текущий пользователь : {currentUser}
Введите комманду : 
    1: Добавить фигуру
    2: Вывести все фигуры
    3: Очистить список фигур
    4: Добавить пользователя
    5: Сменить пользователя
    0: Выход
");
                currentCommand = Console.ReadLine().Trim();
                switch (currentCommand)
                {
                    case "1":
                        paintHandler.AddFigure(currentUser);
                        break;
                    case "2":
                        paintHandler.ShowAllFigure(currentUser);
                        break;
                    case "3":
                        paintHandler.RemoveAllFigure(currentUser);
                        break;
                    case "4":
                        paintHandler.AddUser();
                        break;
                    case "5":
                        currentUser = paintHandler.ChangeUser();
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
