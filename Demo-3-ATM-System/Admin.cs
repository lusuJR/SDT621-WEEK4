using System;

namespace Demo_3_ATM_System
{
    class Admin : ATMUser, IATMUser
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
                Console.WriteLine("1. View ATM Status");
                Console.WriteLine("2. Refill ATM Cash");
                Console.WriteLine("3. View Transactions");
                Console.WriteLine("4. Exit");

                Console.Write("Select option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("ATM is online and operational.");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("ATM cash refilled successfully.");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Transaction report displayed.");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Exiting Admin menu...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
        }
    }
}