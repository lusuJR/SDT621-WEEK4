using System;

namespace Demo_3_ATM_System
{
 class Customer : ATMUser, IATMUser
    {
        public void Login()
        {
            Console.WriteLine("Customer login successful.");
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nCUSTOMER MENU");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                Console.Write("Select option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                if (choice == 1)
                {
                    Console.WriteLine("Your balance is: R" + Balance);
                }

                else if (choice == 2)
                {
                    Console.Write("Enter deposit amount: R");

                    if (double.TryParse(Console.ReadLine(), out double amount))
                    {
                        Balance += amount;

                        Console.WriteLine("Deposit successful.");
                        Console.WriteLine("New balance: R" + Balance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount entered.");
                    }
                }

                else if (choice == 3)
                {
                    Console.Write("Enter withdrawal amount: R");

                    if (double.TryParse(Console.ReadLine(), out double amount))
                    {
                        if (amount <= Balance)
                        {
                            Balance -= amount;

                            Console.WriteLine("Withdrawal successful.");
                            Console.WriteLine("New balance: R" + Balance);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount entered.");
                    }
                }

                else if (choice == 4)
                {
                    Console.WriteLine("Exiting Customer menu...");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
            }
        }
    }
}