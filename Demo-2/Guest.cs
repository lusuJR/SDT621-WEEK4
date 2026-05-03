using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_2
{
    class Guest : User, ILogin
    {
        public void Login()
        {
            Console.WriteLine("Guest login successful.");
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nGUEST MENU");
                Console.WriteLine("1. View Public Courses");
                Console.WriteLine("2. Read Announcement");
                Console.WriteLine("3. Request Registration");
                Console.WriteLine("4. Exit");

                Console.Write("Select option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("\nPUBLIC COURSES");
                    foreach (string course in LMSData.Courses)
                        Console.WriteLine("- " + course);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Announcement: Registration is open for new learners.");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Registration request submitted.");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
