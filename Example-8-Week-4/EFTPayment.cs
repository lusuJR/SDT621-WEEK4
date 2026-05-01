using System;
using System.Collections.Generic;
using System.Text;

namespace Example_8_Week_4
{
    class EFTPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("EFT payment processed: R" +amount);
        }
    }
}
