//Круг
using System;

namespace Task_1_2_CustomPaint.Entities
{
    public class Circle : AbstractFigure
    {
        public double Radius { get; }
        public override double Area { get; }
        public override double Perimeter { get; }

        public override string Name
        {
            get
            {
                return "Circle";
            }
        }

        public Circle(Point center, double radius)
            : base(center)
        {
            Radius = radius;

            Perimeter = 2 * Math.PI * Radius;

            Area = Math.PI * Radius * Radius;
        }
    }
}
