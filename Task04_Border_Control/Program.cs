using System;
using System.Collections.Generic;
using System.Linq;

namespace Task04_Border_Control
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<IControlible> inComings = new List<IControlible>();


            while (true)
            {
                string[] dataLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(dataLine[0].ToUpper() == "END")
                {
                    break;
                }

                if(dataLine.Length == 3)
                {
                    IControlible nextCitizen = new Citizen(dataLine[0], int.Parse(dataLine[1]), dataLine[2]);
                    inComings.Add(nextCitizen);
                }
                
                if(dataLine.Length == 2)
                {
                    IControlible nextRobot = new Robot(dataLine[0], dataLine[1]);
                    inComings.Add(nextRobot);
                }
            }

            string fakeId = Console.ReadLine();

            foreach (IControlible element in inComings)
            {
                element.priintId(fakeId);
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
