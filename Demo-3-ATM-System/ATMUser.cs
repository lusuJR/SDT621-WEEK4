using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_3_ATM_System
{
    class ATMUser
    {
        public string? Username { get; set; }
        public double Balance { get; set; }

        public void DisplayUser()
        {
            Console.WriteLine("\nLogged in as: " + Username);
            Console.WriteLine("Current Balance: R" + Balance);
        }
    }
}
