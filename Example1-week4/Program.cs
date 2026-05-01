using System;


namespace Example1_week4
{
    // Base class
    class Vehicle
    {
        public string Make = "Toyota";
        public void Start()
        {
            Console.WriteLine("Your car starting....");
        }
    }
    // Derived class
    class Car : Vehicle
    {
        public string Model = "Corolla";
        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create object of derived class
            Car myCar = new Car();
            // Access base class method
            myCar.Start();
            // Access derived class method
            myCar.DisplayInfo();

        }
    }
}

