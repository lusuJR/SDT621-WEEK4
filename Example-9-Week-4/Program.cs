using System;


namespace Example_9_Week_4
{
    public class Program
    {
        static void Main()
        {
            IDevice device = new Printer();

            device.TurnOn();

        }
    }
}