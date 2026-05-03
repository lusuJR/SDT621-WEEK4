using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_2
{
    class Student : User, ILogin
    {
        public void Login()
        {
            Console.WriteLine("Student login successful.");
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nSTUDENT MENU");
                Console.WriteLine("1. View Courses");
                Console.WriteLine("2. View Assessments");
                Console.WriteLine("3. Submit Assessment");
                Console.WriteLine("4. View My Submissions");
                Console.WriteLine("5. Exit");

                Console.Write("Select option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("\nAVAILABLE COURSES");
                    foreach (string course in LMSData.Courses)
                        Console.WriteLine("- " + course);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nAVAILABLE ASSESSMENTS");
                    foreach (string assessment in LMSData.Assessments)
                        Console.WriteLine("- " + assessment);
                }
                else if (choice == 3)
                {
                    Console.Write("Enter assessment name: ");
                    string assessmentName = Console.ReadLine()!;

                    string submission = Username + " submitted: " + assessmentName;
                    LMSData.Submissions.Add(submission);

                    Console.WriteLine("Assessment submitted successfully.");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nMY SUBMISSIONS");
                    foreach (string submission in LMSData.Submissions)
                    {
                        if (submission.StartsWith(Username!))
                            Console.WriteLine("- " + submission);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
