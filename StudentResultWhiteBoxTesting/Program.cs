
/*
Student Result Processing System Using Multiple Interfaces
Learning Objective

Students must:

implement multiple interfaces
test separate logic modules
perform white-box testing
identify logic defects
correct incorrect conditions
produce test evidence
 
  */

using System;

namespace StudentResultWhiteBoxTesting
{

    class Program
    {
        static void Main()
        {
            StudentProcessor processor = new();

            while (true)
            {
                Console.Write("\nEnter student mark: ");

                int mark;

                if (!int.TryParse(Console.ReadLine(), out mark))
                {
                    Console.WriteLine("Invalid input. Enter numbers only.");
                    continue;
                }

                if (!processor.ValidateMark(mark))
                {
                    Console.WriteLine("Invalid mark entered.");
                }
                else
                {
                    Console.WriteLine("Result: " +
                        processor.CalculateResult(mark));

                    Console.WriteLine("Grade: " +
                        processor.AssignGrade(mark));
                }

                Console.Write("\nDo you want to enter another mark? (Y/N): ");
                string choice = Console.ReadLine()!.ToUpper();

                if (choice != "Y")
                {
                    Console.WriteLine("System closing... Goodbye!");
                    break;
                }
            }
        }
    }
}