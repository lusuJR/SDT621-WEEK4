using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_2
{
    class Admin : User, ILogin
    {
        public void Login()
        {
            Console.WriteLine("Admin login successful.");
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nADMIN MENU");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Add Assessment");
                Console.WriteLine("4. View Students");
                Console.WriteLine("5. View Courses");
                Console.WriteLine("6. View Assessments");
                Console.WriteLine("7. Exit");

                Console.Write("Select option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter student name: ");
                    LMSData.Students.Add(Console.ReadLine()!);
                    Console.WriteLine("Student added successfully.");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter course name: ");
                    LMSData.Courses.Add(Console.ReadLine()!);
                    Console.WriteLine("Course added successfully.");
                }
                else if (choice == 3)
                {
                    Console.Write("Enter assessment name: ");
                    LMSData.Assessments.Add(Console.ReadLine()!);
                    Console.WriteLine("Assessment added successfully.");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nSTUDENTS");
                    foreach (string student in LMSData.Students)
                        Console.WriteLine("- " + student);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("\nCOURSES");
                    foreach (string course in LMSData.Courses)
                        Console.WriteLine("- " + course);
                }
                else if (choice == 6)
                {
                    Console.WriteLine("\nASSESSMENTS");
                    foreach (string assessment in LMSData.Assessments)
                        Console.WriteLine("- " + assessment);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
