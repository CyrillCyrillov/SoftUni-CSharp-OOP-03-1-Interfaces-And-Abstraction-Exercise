using System;
using System.Collections.Generic;
using System.Text;

namespace Task03_Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        

        public void Browsing(string url)
        {
            Console.WriteLine($"Browsing: {url}!");
        }

        void ICalling.Calling(string phoneNumber)
        {
            Console.WriteLine($"Calling... {phoneNumber}");
        }

        
    }
}
