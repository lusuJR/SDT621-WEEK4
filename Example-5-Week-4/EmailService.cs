namespace Example_5_Week_4
{
    class EmailService : IMessageService
    {
        public void Exit(int message)
        {
            Console.WriteLine(2 / 4);
        }

        public void Received(int message)
        {
            Console.WriteLine(1 + 2);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Sending Email: " + message   );
        }

        public void SendMessage(int message)
        {
            Console.WriteLine("Exit");
        }

        public void SendMoney(int message)
        {
            throw new NotImplementedException();
        }
    }
}
