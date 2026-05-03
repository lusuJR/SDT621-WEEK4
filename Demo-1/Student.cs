using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_1
{
    class Student : User, ILogin
    {
        public void Login()
        {
            Console.WriteLine("Student login successful.");
        }

        public void ShowMenu()
        {
            Console.WriteLine("\nSTUDENT MENU");
            Console.WriteLine("1. View Assessments");
            Console.WriteLine("2. Submit Assessment");
            Console.WriteLine("3. View Marks");
            Console.WriteLine("4. View Courses");
        }
    }
}
