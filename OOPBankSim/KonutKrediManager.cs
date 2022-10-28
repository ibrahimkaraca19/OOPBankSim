using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBankSim
{
    internal class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
