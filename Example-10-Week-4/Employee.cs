using System;
using System.Collections.Generic;
using System.Text;

namespace Example_10_Week_4
{
    abstract class Employee
    {
        public string Name { get; set; }

        public void DisplayName()
        {
            Console.WriteLine("Employee Name: " + Name);
        }

        public abstract double CalculateSalary();
    }
}
