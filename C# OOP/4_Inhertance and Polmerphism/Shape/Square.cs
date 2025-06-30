using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polmerphism.Shape
{
    internal class Square : Shape
    {
        #region Properties
        public double Length { get; set; }
        #endregion
        #region Constructor
        public Square(double length)
        {
            Length = length;
        }
        #endregion
        #region Methods
        public override double Area()
        {
            double area = Length * Length;
            Console.WriteLine($"Area of the square: {area}");
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = 4 * Length;
            Console.WriteLine($"Perimeter of the square: {perimeter}");
            return perimeter;
        }
        #endregion
    }
}