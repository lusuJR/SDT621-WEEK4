using System;
using System.Collections.Generic;
using System.Text;

namespace Example_10_Week_4
{
    class PartTimeEmployee : Employee
    {
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public override double CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }
}
