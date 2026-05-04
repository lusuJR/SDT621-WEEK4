using System;
using System.Collections.Generic;
using System.Text;

namespace Example1_week4
{
    class Car : Vehicle
    {
        public string Model = "Corolla";
        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}");
        }
    }
}
