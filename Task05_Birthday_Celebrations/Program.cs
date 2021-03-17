using System;
using System.Linq;
using System.Collections.Generic;

namespace Task05_Birthday_Celebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ICelebrateble> whoHaveBirthday = new List<ICelebrateble>();
            
            while (true)
            {
                string[] nextDatas = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(nextDatas[0].ToUpper() == "END")
                {
                    break;
                }

                switch (nextDatas[0]) //Types
                {
                    case "Citizen":
                        Citizen nextCitizen = new Citizen(nextDatas[1], int.Parse(nextDatas[2]), nextDatas[3], nextDatas[4]);
                        whoHaveBirthday.Add(nextCitizen);
                        break;

                    case "Pet":
                        Pet nextPet = new Pet(nextDatas[1], nextDatas[2]);
                        whoHaveBirthday.Add(nextPet);
                        break;

                    default:
                        break;
                }
            }

            string year = Console.ReadLine();

            foreach (ICelebrateble element in whoHaveBirthday)
            {
                element.Printcelebrating(year);
            }


            //Console.WriteLine("Hello World!");
        }
    }
}
