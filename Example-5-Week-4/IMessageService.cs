namespace Example_5_Week_4
{
    interface IMessageService
    {
        void SendMessage(string message);
        void SendMessage(int message);

        void SendMoney(int message);
        void Received(int message);
        void Exit(int message);
    }
}
