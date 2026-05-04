using System;
using System.Collections.Generic;
using System.Text;

namespace Example1_week4
{
     class Vehicle
    {
        public string Make = "Toyota";
        public string Color = "Red";
        public void Start()
        {
            Console.WriteLine("Your car starting....");
        }

        public void Turn()
        {
            Console.WriteLine("Your car turning....");
        }
    }
}
