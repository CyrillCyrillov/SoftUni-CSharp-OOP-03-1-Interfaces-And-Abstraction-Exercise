using System;
using System.Collections.Generic;
using System.Text;

namespace Task03_Telephony
{
    public class StationaryPhone : ICalling
    {
        public void Calling(string phoneNumber)
        {
            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}
