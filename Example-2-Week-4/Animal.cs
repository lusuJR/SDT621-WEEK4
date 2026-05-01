using System;
using System.Collections.Generic;
using System.Text;

namespace Example_2_Week_4
{
    class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
        }

        // virtual method
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a general animal sound.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves around the zoo.");
        }
    }
}
