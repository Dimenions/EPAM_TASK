using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1_2_CustomPaint.Entities;

namespace Task_1_2_CustomPaint
{
    public class PaintHandler
    {
        Dictionary<User, List<NameGeometricObject>> userFigurePairs = new Dictionary<User, List<NameGeometricObject>>();

        public PaintHandler(User user)
        {
            userFigurePairs.Add(user, new List<NameGeometricObject>());
        }

        public void AddFigure(User user) // Добавить фигуру
        {
            string currentCommand = "";

            bool isChoosing = true;
            while (isChoosing)
            {
                Console.WriteLine();
                Console.WriteLine(
    @"Введите комманду : 
    1: Точка
    2: Линия
    3: Круг
    4: Кольцо
    5: Треугольник
    6: Прямоугольник
    7: Квадрат");

                isChoosing = false;
                currentCommand = Console.ReadLine();
                switch (currentCommand)
                {
                    case "1":
                        userFigurePairs[user].Add(CreatePoint());
                        break;
                    case "2":
                        userFigurePairs[user].Add(CreateLine());
                        break;
                    case "3":
                        userFigurePairs[user].Add(CreateCircle());
                        break;
                    case "4":
                        userFigurePairs[user].Add(CreateRing());
                        break;
                    case "5":
                        userFigurePairs[user].Add(CreateTriangle());
                        break;
                    case "6":
                        userFigurePairs[user].Add(CreateRectangle());
                        break;
                    case "7":
                        userFigurePairs[user].Add(CreateSquare());
                        break;
                    default:
                        Console.WriteLine("ВЫВОД: Выберите правильный вариант!");
                        isChoosing = true;
                        break;
                }
            }
        }

        public void ShowAllFigure(User user)// Показать все фигуры
        {
            foreach (var figure in userFigurePairs[user])
            {
                Console.WriteLine(figure.Name);
            }
        }

        public void RemoveAllFigure(User user)
        {
            userFigurePairs[user].Clear();
        }

        public void AddUser(User user)
        {
            userFigurePairs.Add(user, new List<NameGeometricObject>());
        }

        public void AddUser(string username)
        {
            userFigurePairs.Add(new User { Name = username }, new List<NameGeometricObject>());
        }

        public void AddUser()
        {
            Console.WriteLine("ВЫВОД: Введите пользователя");
            Console.Write("ВВОД: ");
            string name = Console.ReadLine();
            User user = new User() { Name = name };

            if (!userFigurePairs.Keys.Contains(user))
            {
                userFigurePairs.Add(user, new List<NameGeometricObject>());
            }
            else
            {
                Console.WriteLine("ВЫВОД: Пользователь с таким именем уже существует!");
            }
        }

        public User ChangeUser()
        {
            Console.WriteLine("ВЫВОД: Доступные пользователи:");
            // Берём всех пользователей
            var allUsers = userFigurePairs.Keys.ToArray();
            // Выводим их на экран
            for (int i = 0; i < allUsers.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {allUsers[i]}");
            }

            int userID = 0;
            while (true)
            {
                Console.WriteLine("ВЫВОД: Введите номер пользователя");
                Console.Write("ВВОД: ");

                if (int.TryParse(Console.ReadLine(), out userID))
                {
                    if (userID - 1 >= 0 && userID - 1 < allUsers.Length)
                    {
                        return allUsers[userID - 1];
                    }
                    else
                    {
                        Console.WriteLine("ВЫВОД: Введён неверный id пользователя");
                        continue;
                    }
                }
            }
        }

        private double InputCoordinate(string coordinateReceived)
        {
            while (true)
            {
                Console.Write($"ВВОД {coordinateReceived}: ");
                if (double.TryParse(Console.ReadLine(), out double coordinate))
                {
                    return coordinate;
                }
                else
                {
                    Console.WriteLine("Ошибка! Неверное значение! Введите координату снова.");
                }
            }
        }

        private double InputMoreThanZero()
        {
            while (true)
            {
                Console.Write($"ВВОД: ");

                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Ошибка! Неправильное значение! Введите число больше нуля.");
                        continue;
                    }

                    return value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Неправильное значение! Введите корректное значение.");
                }
            }
        }

        private double InputDouble()
        {
            while (true)
            {
                Console.Write($"ВВОД: ");

                if (double.TryParse(Console.ReadLine(), out double doubleValue))
                {
                    return doubleValue;
                }
                else
                {
                    Console.WriteLine("Ошибка! Неправильное значение! Введите корректное значение.");
                }
            }
        }

        private Point CreatePoint()
        {
            Console.WriteLine("ВЫВОД: Введите координату X: ");
            var x = InputCoordinate("X");

            Console.WriteLine("ВЫВОД: Введите координату Y: ");
            var y = InputCoordinate("Y");

            return new Point(x, y);
        }

        private Line CreateLine()
        {
            Console.WriteLine("ВЫВОД: Введите первую точку");
            var point1 = CreatePoint();

            Console.WriteLine("ВЫВОД: Введите вторую точку");
            var point2 = CreatePoint();

            var line = new Line(point1, point2);
            if (Validator.IsValid(line))
            {
                return line;
            }

            return null;
        }

        private Circle CreateCircle()
        {
            Console.WriteLine("ВЫВОД: Введите центр");
            var center = CreatePoint();

            Console.WriteLine("ВЫВОД: Введите радиус: ");
            double radius = InputMoreThanZero();

            var circle = new Circle(center, radius);
            if (Validator.IsValid(circle))
            {
                return circle;
            }

            return null;
        }

        private Ring CreateRing()
        {
            Console.WriteLine("ВЫВОД: Введите центр");
            var center = CreatePoint();

            Console.WriteLine("ВЫВОД: Введите радиус первой окружности: ");
            var radius1 = InputMoreThanZero();

            Console.WriteLine("ВЫВОД: Введите радиус второй окружности: ");
            var radius2 = InputMoreThanZero();

            var ring = new Ring(center, Math.Min(radius1, radius2), Math.Max(radius1, radius2));
            if (Validator.IsValid(ring))
            {
                return ring;
            }

            return null;
        }

        private Triangle CreateTriangle()
        {

            Console.WriteLine("ВЫВОД: Введите первую точку");
            var point1 = CreatePoint();

            Console.WriteLine("ВЫВОД: Введите вторую точку");
            var point2 = CreatePoint();

            Console.WriteLine("ВЫВОД: Введите третью точку");
            var point3 = CreatePoint();

            var triangle = new Triangle(point1, point2, point3);
            if (Validator.IsValid(triangle))
            {
                return triangle;
            }

            return null;
        }

        private Rectangle CreateRectangle()
        {
            Console.WriteLine("ВЫВОД: Введите центр");
            var center = CreatePoint();

            Console.WriteLine("ВЫВОД: Введите длину первой стороны: ");
            var firstSide = InputMoreThanZero();

            Console.WriteLine("ВЫВОД: Введите длину второй стороны: ");
            var secondSide = InputMoreThanZero();

            var rectangle = new Rectangle(center, firstSide, secondSide);
            if (Validator.IsValid(rectangle))
            {
                return rectangle;
            }

            return null;
        }

        private Square CreateSquare()
        {
            Console.WriteLine("ВЫВОД: Введите центр");
            var center = CreatePoint();

            Console.WriteLine("ВЫВОД: Введите сторону: ");
            var side = InputMoreThanZero();

            var square = new Square(center, side);
            if (Validator.IsValid(square))
            {
                return square;
            }

            return null;
        }
    }
}
