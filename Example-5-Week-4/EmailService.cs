namespace Example_5_Week_4
{
    class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }
}
