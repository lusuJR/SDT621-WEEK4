using System;
using System.Collections.Generic;
using System.Text;

namespace Example_10_Week_4
{
    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }
        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
