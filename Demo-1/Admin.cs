using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_1
{
    class Admin : User, ILogin
    {
        public void Login()
        {
            Console.WriteLine("Admin login successful.");
        }

        public void ShowMenu()
        {
            Console.WriteLine("\nADMIN MENU");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. Manage Users");
            Console.WriteLine("4. View Reports");
        }
    }
}
