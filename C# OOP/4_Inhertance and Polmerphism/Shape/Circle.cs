using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polmerphism.Shape
{
    internal class Circle : Shape
    {
        #region Properties
        public double Radius { get; set; }
        #endregion
        #region Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
        #endregion
        #region Methods
        public override double Area()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Area of the circle: {area}");
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            Console.WriteLine($"Perimeter of the circle: {perimeter}");
            return perimeter;
        }
        #endregion
    }
}