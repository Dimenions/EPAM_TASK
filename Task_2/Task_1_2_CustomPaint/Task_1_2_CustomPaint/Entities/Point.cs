//Точка
namespace Task_1_2_CustomPaint.Entities
{
    public class Point : NameGeometricObject
    {
        public double X { get; }
        public double Y { get; }

        public override string Name
        {
            get
            {
                return "Point";
            }
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        //Определяем равны ли два экземпляра объекта
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Point point = obj as Point;
            if (point as Point == null)
            {
                return false;
            }

            return X == point.X && Y == point.Y;
        }

        // Операторы проверки на равенство
        public static bool operator == (Point firstPoint, Point secondPoint)
        {
            if (firstPoint is null || secondPoint is null)
            {
                return false;
            }

            return firstPoint.X == secondPoint.X && firstPoint.Y == secondPoint.Y;
        }

        public static bool operator != (Point firstPoint, Point secondPoint)
        {
            if (firstPoint == null || secondPoint == null)
            {
                return false;
            }

            return firstPoint.X != secondPoint.X || firstPoint.Y != secondPoint.Y;
        }
    }
}
