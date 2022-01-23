namespace Task_1_2_CustomPaint.Entities
{
    public abstract class AbstractFigure : NameGeometricObject
    {
        public abstract double Perimeter { get; }

        public abstract double Area { get; }

        public Point Center { get; }

        public AbstractFigure(Point center)
        {
            Center = center;
        }
    }
}
