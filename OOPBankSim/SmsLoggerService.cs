using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBankSim
{
    internal class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms gönderildi!");
        }
    }
}
