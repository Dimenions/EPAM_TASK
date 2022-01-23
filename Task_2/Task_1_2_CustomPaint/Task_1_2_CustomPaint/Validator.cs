using System;
using Task_1_2_CustomPaint.Entities;

namespace Task_1_2_CustomPaint
{
    public static class Validator
    {
        public static bool IsValid(Line line)
        {
            if (line.StartPoint == line.EndPoint)
            {
                throw new Exception("Ошибка! Заданы две точки в одном месте!");
            }

            if (line.StartPoint == null || line.EndPoint == null)
            {
                throw new NullReferenceException("Ошибка! Задана точка значением null!");
            }

            return true;
        }

        public static bool IsValid(Rectangle rectangle)
        {
            if (rectangle.Height <= 0 || rectangle.Width <= 0)
            {
                throw new Exception("Ошибка! Длина строны не может быть меньше или равна нулю!");
            }

            return true;
        }

        public static bool IsValid(Square square)
        {
            if (square.SideLength <= 0)
            {
                throw new Exception("Ошибка! Длина строны не может быть меньше или равна нулю!");
            }

            return true;
        }

        public static bool IsValid(Triangle triangle)
        {
            Point point1 = triangle.Line1.StartPoint;
            Point point2 = triangle.Line2.StartPoint;

            Point point3 = triangle.Line3.StartPoint;
            if ((point3.X - point1.X) / (point2.X - point1.X) == (point3.Y - point1.X) / (point2.Y - point1.X))
            {
                throw new Exception("Ошибка! Точки треугольника лежат на одной прямой");
            }

            return true;
        }

        public static bool IsValid(Circle circle)
        {
            if (circle.Radius <= 0)
            {
                throw new Exception("Ошибка! Радиус не может быть равен 0 или меньше!");
            }

            return true;
        }

        public static bool IsValid(Ring ring)
        {
            if (ring.InnerCircle.Radius == ring.OuterCircle.Radius && ring.InnerCircle.Center == ring.OuterCircle.Center)
            {
                throw new Exception("Ошибка! Внешний и внутренний круг заданы одинаково!");
            }

            return true;
        }
    }
}
