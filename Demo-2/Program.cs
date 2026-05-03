using System;

namespace Demo_2 
{
    class Program
    {
        static void Main() 
        {
            while (true)
            {
                Console.WriteLine("\n===== CAMPUS LMS LOGIN SYSTEM =====");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Student");
                Console.WriteLine("3. Guest");
                Console.WriteLine("4. Close System");

                Console.Write("Select role: ");
                int roleChoice = Convert.ToInt32(Console.ReadLine());

                if (roleChoice == 4)
                    break;

                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                ILogin loginUser;

                if (roleChoice == 1)
                {
                    Admin admin = new Admin();
                    admin.Username = username;
                    loginUser = admin;
                    admin.DisplayUser();
                }
                else if (roleChoice == 2)
                {
                    Student student = new Student();
                    student.Username = username;
                    loginUser = student;
                    student.DisplayUser();
                }
                else
                {
                    Guest guest = new Guest();
                    guest.Username = username;
                    loginUser = guest;
                    guest.DisplayUser();
                }

                loginUser.Login();
                loginUser.ShowMenu();
            }

            Console.WriteLine("System closed.");
        }
    }
    }
