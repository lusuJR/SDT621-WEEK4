using System;

namespace Demo_3_ATM_System 
{
    class Program
    {
        static void Main(string[] args) 
        {
            while (true)
            {
                Console.WriteLine("\n===== ATM LOGIN SYSTEM =====");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Guest");
                Console.WriteLine("4. Close System");

                Console.Write("Select role: ");
                int roleChoice = Convert.ToInt32(Console.ReadLine());

                if (roleChoice == 4)
                {
                    break;
                }

                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                IATMUser atmUser;

                if (roleChoice == 1)
                {
                    Admin admin = new Admin();
                    admin.Username = username;
                    admin.Balance = 0;

                    atmUser = admin;
                    admin.DisplayUser();
                }
                else if (roleChoice == 2)
                {
                    Customer customer = new Customer();
                    customer.Username = username;
                    customer.Balance = 5000;

                    atmUser = customer;
                    customer.DisplayUser();
                }
                else
                {
                    Guest guest = new Guest();
                    guest.Username = username;
                    guest.Balance = 0;

                    atmUser = guest;
                    guest.DisplayUser();
                }

                atmUser.Login();
                atmUser.ShowMenu();
            }

            Console.WriteLine("ATM system closed.");
        }
    }
        
    }