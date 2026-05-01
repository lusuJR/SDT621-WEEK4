using Example_2_Week_4;
using System;


namespace Example1_week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Lion name: ");
            string lionName = Console.ReadLine()!;

            Console.Write("Enter Penguin name: ");
            string penguinName = Console.ReadLine()!;

            Animal lion = new Lion(lionName);
            Penguin penguin = new Penguin(penguinName);

            Console.WriteLine("\n--- Zoo Activities ---");

            lion.MakeSound();     // override demo
            penguin.MakeSound();  // inherited virtual method

            lion.Move();          // base method
            penguin.Move();       // hidden method using new

            Console.ReadLine();
        }
    }
}