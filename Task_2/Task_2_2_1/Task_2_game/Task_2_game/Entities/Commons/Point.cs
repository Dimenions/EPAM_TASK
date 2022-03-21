//Точка как координата в пространстве (2д)

namespace Task_2_game
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Point point = obj as Point;
            if (point as Point == null)
                return false;

            return X == point.X && Y == point.Y;
        }
    }
}
