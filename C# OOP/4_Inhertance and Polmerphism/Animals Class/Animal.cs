using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_and_Polmerphism
{
    internal class Animal
    {
        public string? name { get; set; }
        public string? SkinColor { get; set; }
        public string? EyeColor { get; set; }
        public double Weight { get; set; }

        public void sleep()
        {
            Console.WriteLine("Good bye");
        }
        public void Eat()
        {
            Console.WriteLine("Thank you");
        }
    }
}