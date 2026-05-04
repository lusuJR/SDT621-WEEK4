using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Week_4
{
    class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age) { }

        // override method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} and {Age} roars loudly.");
        }
    }
}
