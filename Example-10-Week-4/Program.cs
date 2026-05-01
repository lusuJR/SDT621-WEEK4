using System;

namespace Example_10_Week_4 
{
    public class Program
    {
      static void Main()
        {
            Console.WriteLine("Select Employee Type:");
            Console.WriteLine("1 - Full Time Employee");
            Console.WriteLine("2 - Part Time Employee");

            int choice = Convert.ToInt32(Console.ReadLine());

            Employee employee;

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine()!;

            if (choice == 1)
            {
                FullTimeEmployee fullTime = new FullTimeEmployee();

                fullTime.Name = name;

                Console.WriteLine("Enter Monthly Salary:");
                fullTime.MonthlySalary =
                Convert.ToDouble(Console.ReadLine());

                employee = fullTime;
            }
            else if (choice == 2)
            {
                PartTimeEmployee partTime = new PartTimeEmployee();

                partTime.Name = name;

                Console.WriteLine("Enter Hours Worked:");
                partTime.HoursWorked =
                Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Hourly Rate:");
                partTime.HourlyRate =
                Convert.ToDouble(Console.ReadLine());

                employee = partTime;
            }
            else
            {
                Console.WriteLine("Invalid selection");
                return;
            }

            Console.WriteLine();
            employee.DisplayName();

            Console.WriteLine("Salary: R" +
            employee.CalculateSalary());
        }
    }
}
