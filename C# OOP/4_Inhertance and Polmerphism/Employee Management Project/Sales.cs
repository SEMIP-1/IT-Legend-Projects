using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Project
{
    class Sales: Employee
    {
        public decimal Commission { get; set; }
        public Sales()
        {
            Commission = 0;
        }
        public Sales(decimal Commission)
        {
            this.Commission = Commission;
        }
        public void CreateMeeting()
        {
            Console.WriteLine("Sales is creating a meeting");
        }
    }
}