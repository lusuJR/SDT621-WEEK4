using System;
using System.Collections.Generic;
using System.Text;

namespace Example_11_Week_4
{
    sealed class SecurityLogger
    {
        public void LogActivity(string username)
        {
            Console.WriteLine("Security activity logged for: " + username);
        }
    }
}
