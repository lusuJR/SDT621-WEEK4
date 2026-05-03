using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_1
{
    class Guest : User, ILogin
    {
        public void Login()
        {
            Console.WriteLine("Guest login successful.");
        }

        public void ShowMenu()
        {
            Console.WriteLine("\nGUEST MENU");
            Console.WriteLine("1. View Available Courses");
            Console.WriteLine("2. Read Public Announcements");
            Console.WriteLine("3. Request Registration");
        }
    }
}
