using System;

namespace Example_8_Week_4
{
    public class Program
    {
        static void Main()
        {
            IPayment payment;

            Console.WriteLine("Enter Credit Card payment amount:");
            double creditAmount = Convert.ToDouble(Console.ReadLine());

            payment = new CreditCardPayment();
            payment.ProcessPayment(creditAmount);

            Console.WriteLine();

            Console.WriteLine("Enter EFT payment amount:");
            double eftAmount = Convert.ToDouble(Console.ReadLine());

            payment = new EFTPayment();
            payment.ProcessPayment(eftAmount);
        }
    }
}