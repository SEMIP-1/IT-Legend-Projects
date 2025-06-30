using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polmerphism.Shape
{
    class Shape
    {
        public virtual double Area()
        {
           Console.WriteLine("Area of the shape");
            return 0;
        }
        public virtual double Perimeter()
        {
            Console.WriteLine("Perimeter of the shape");
            return 0;
        }
    }
}