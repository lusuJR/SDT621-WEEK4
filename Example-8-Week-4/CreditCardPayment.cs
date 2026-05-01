using System;
using System.Collections.Generic;
using System.Text;

namespace Example_8_Week_4
{
    class CreditCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Credit card payment processed: R" +amount);
        }
    }
}
