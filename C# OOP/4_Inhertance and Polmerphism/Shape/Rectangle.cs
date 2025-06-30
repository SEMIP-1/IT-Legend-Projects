using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polmerphism.Shape
{
    internal class Rectangle : Shape
    {
        #region Properties
        public double Length { get; set; }
        public double Width { get; set; }
        #endregion
        #region Constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        #endregion
        #region Methods
        public override double Area()
        {
            double area = Length * Width;
            Console.WriteLine($"Area of the rectangle: {area}");
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = 2 * (Length + Width);
            Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
            return perimeter;
        }
        #endregion
    }
}