using System;
using System.Collections.Generic;
using System.Text;

namespace Example_3_Week_4
{
    class Human
    {
        public string Name;            // accessible everywhere
        private int Age;               // accessible only inside Human class
        protected string Nationality;  // accessible in Human + derived classes
        internal string Country = "South Africa"; // accessible inside same project

        public Human(string name, int age, string nationality)
        {
            Name = name;
            Age = age;
            Nationality = nationality;
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
