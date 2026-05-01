using System;

namespace Example_7_Week_4
{
    public class Program
    {
        static void Main()
        {
            IMessageService service = new EmailService();

            service.SendMessage("Hello Mr. Lusukama ");
        }
    }
}