using System;
using System.Linq;

namespace Task03_Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNummbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] sites = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string curentNumber in phoneNummbers)
            {
                
                if((curentNumber.All(char.IsDigit)) && (curentNumber.Length == 7))
                {
                    ICalling stationaryPhobe = new StationaryPhone();
                    stationaryPhobe.Calling(curentNumber);
                }
                else if ((curentNumber.All(char.IsDigit)) && (curentNumber.Length == 10))
                {
                    ICalling smartPhone = new Smartphone();
                    smartPhone.Calling(curentNumber);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (string site in sites)
            {
                if(site.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    IBrowsing smartPhone = new Smartphone();
                    smartPhone.Browsing(site);
                }
            }
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
