//Прямоугольник
namespace Task_1_2_CustomPaint.Entities
{
    public class Rectangle : AbstractFigure
    {
        public double Height { get; }
        public double Width { get; }

        public override string Name {
            get
            {
                return "Rectangle";
            }
        }
        //Конструкторы
        public Rectangle(Point center, double edge)
            : base(center)
        {
            Height = edge;
            Width = edge;
        }

        public Rectangle(Point center, double height, double width) 
            : base(center)
        {
            Height = height;
            Width = width;
        }

        public Rectangle(double x_center, double y_center, double sideLength) 
            : base(new Point(x_center, y_center))
        {
            Height = sideLength;
            Width = sideLength;
        }

        public Rectangle(double x_center, double y_center, double height, double width) 
            : this(x_center, y_center, height)
        {
            Width = width;
        }
        //-------------------------------------------------------
        public override double Perimeter
        {
            get
            {
                return 2 * Height + 2 * Width;
            }
        }

        public override double Area
        {
            get
            {
                return Height * Width;
            }
        }
    }
}
