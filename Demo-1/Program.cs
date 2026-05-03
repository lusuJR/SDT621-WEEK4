using System;

namespace Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== LOGIN SYSTEM =====");

            Console.WriteLine("\nSelect your role:");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Student");
            Console.WriteLine("3. Guest");

            Console.Write("\nEnter role option: ");
            int roleChoice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            ILogin loginUser;

            if (roleChoice == 1)
            {
                Admin admin = new Admin();
                admin.Username = username;
                admin.Password = password;

                loginUser = admin;
                admin.DisplayUser();
            }
            else if (roleChoice == 2)
            {
                Student student = new Student();
                student.Username = username;
                student.Password = password;

                loginUser = student;
                student.DisplayUser();
            }
            else
            {
                Guest guest = new Guest();
                guest.Username = username;
                guest.Password = password;

                loginUser = guest;
                guest.DisplayUser();
            }

            // Polymorphism:
            // Same method calls, different role behaviour
            loginUser.Login();
            loginUser.ShowMenu();

            Console.WriteLine("\nSystem process completed.");
        }
    }
    }