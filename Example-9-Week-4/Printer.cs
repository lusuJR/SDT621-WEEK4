using System;
using System.Collections.Generic;
using System.Text;

namespace Example_9_Week_4
{
    class Printer : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Printer turned on");
        }
    }
}
