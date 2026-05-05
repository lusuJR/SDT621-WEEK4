using System;

namespace Example_5_Week_4 
{
    public class Program
    {
        static void Main() 
        {

            EmailService service = new EmailService();

            service.SendMessage(12345);

            EmailService service2 = new EmailService();

            service.SendMessage("Welcome to CTU Training Solutions ");

        }
    }
}