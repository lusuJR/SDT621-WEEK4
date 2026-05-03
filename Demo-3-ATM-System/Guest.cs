using System;

namespace Demo_3_ATM_System
{
    class Guest : ATMUser, IATMUser
    {
        public void Login()
        {
            Console.WriteLine("Guest access granted.");
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nGUEST MENU");
                Console.WriteLine("1. View ATM Services");
                Console.WriteLine("2. View Bank Contact Details");
                Console.WriteLine("3. Exit");

                Console.Write("Select option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                if (choice == 1)
                {
                    Console.WriteLine("ATM services: Withdraw, Deposit, Balance Enquiry.");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Bank contact: 0800 123 456");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Exiting Guest menu...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
    }
}