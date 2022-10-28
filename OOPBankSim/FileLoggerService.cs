using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBankSim
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı!");
        }
    }
}
