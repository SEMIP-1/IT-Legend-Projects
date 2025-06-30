using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Project
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }
        public decimal Salary { get; set; }
    }
}