using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_2
{
    class User
    {
        public string? Username { get; set; }

        public void DisplayUser()
        {
            Console.WriteLine("\nLogged in as: " + Username);
        }
    }
}
