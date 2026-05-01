using System;

namespace Example_11_Week_4
{
    public class Program
    {
        static void Main()
        {
            SecurityLogger logger = new SecurityLogger();

            Console.WriteLine("Enter username:");
            string username = Console.ReadLine()!;

            logger.LogActivity(username);
            
        }
    }
}