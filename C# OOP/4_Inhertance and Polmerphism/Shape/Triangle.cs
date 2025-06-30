using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polmerphism.Shape
{
    internal class Triangle : Shape
    {
        #region Properties
        public double Base { get; set; }
        public double Height { get; set; }
        #endregion
        #region Constructor
        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }
        #endregion
        #region Methods
        public override double Area()
        {
            double area = 0.5 * Base * Height;
            Console.WriteLine($"Area of the triangle: {area}");
            return area;
        }
        public override double Perimeter()
        {
            // Assuming it's an equilateral triangle for simplicity
            double perimeter = 3 * Base;
            Console.WriteLine($"Perimeter of the triangle: {perimeter}");
            return perimeter;
        }
        #endregion
    }
}