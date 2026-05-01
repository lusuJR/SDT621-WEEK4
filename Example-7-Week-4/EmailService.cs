using System;
using System.Collections.Generic;
using System.Text;

namespace Example_7_Week_4
{
    class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email Sent: " + message);
        }
    }
}
