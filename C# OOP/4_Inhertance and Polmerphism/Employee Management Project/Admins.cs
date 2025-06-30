using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Project
{
    class Admins: Employee
    {
        public decimal Allowances { get; set; }

        public void HireEmployee()
        {
            Console.WriteLine("Admin is hiring an employee");
        }
    }
}