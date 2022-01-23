//Квадрат
namespace Task_1_2_CustomPaint.Entities
{
    public class Square : AbstractFigure
    {
        private Rectangle rectangle;

        public override double Perimeter { get; }
        public override double Area { get; }

        public double SideLength
        {
            get
            {
                return rectangle.Height;
            }
        }

        public override string Name
        {
            get
            {
                return "Square";
            }
        }

        public Square(Point center, double sideLength) 
            : base(center)
        {
            rectangle = new Rectangle(center, sideLength);

            Perimeter = rectangle.Perimeter;
            Area = rectangle.Area;
        }
    }
}
