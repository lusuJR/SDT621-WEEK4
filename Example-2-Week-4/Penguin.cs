using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Week_4
{
    class Penguin : Animal
    {
        public Penguin(string name, int age) : base(name, age) { }

        // new method (method hiding)
        public new void Move()
        {
            Console.WriteLine($"{Name} and {Age} waddles and swims.");
        }
    }
}
