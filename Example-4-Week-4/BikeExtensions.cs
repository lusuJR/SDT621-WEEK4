using System;
using System.Collections.Generic;
using System.Text;

namespace Example_4_Week_4
{
    static class BikeExtensions
    {
        public static void ShowBikeMessage(this Bike bike)
        {
            Console.WriteLine("Extension method added to Bike class");
            Console.WriteLine("Bike Brand : " +bike.Brand);
        }
    }
}
