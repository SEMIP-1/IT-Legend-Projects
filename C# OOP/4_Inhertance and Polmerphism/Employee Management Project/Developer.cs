using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Project
{
    class Developer: Employee
    {
        decimal RatePerHour { get; set; }
        public Developer() 
        {
            RatePerHour = 0;
        }
        public Developer(decimal Rate)
        {
            RatePerHour = Rate;
        }
        public void MakeOverTime()
        {
            Console.WriteLine("Developer is making overtime");
        }
    }
}