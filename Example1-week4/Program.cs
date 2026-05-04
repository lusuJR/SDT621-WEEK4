using System;


namespace Example1_week4
{
    // Base class
    //class Vehicle
    //{
    //    public string Make = "Toyota";
    //    public string Color = "Red";
    //    public void Start()
    //    {
    //        Console.WriteLine("Your car starting....");
    //    }

    //    public void Turn()
    //    {
    //        Console.WriteLine("Your car turning....");
    //    }


    //}
    // Derived class
    //class Car : Vehicle
    //{
        
    //}

    class Program
    {
        static void Main(string[] args)
        {
            // Create object of derived class
            Car myCar = new Car();
            // Access base class method
            myCar.Start();

            myCar.Turn();
            // Access derived class method
            myCar.DisplayInfo();

        }
    }
}

