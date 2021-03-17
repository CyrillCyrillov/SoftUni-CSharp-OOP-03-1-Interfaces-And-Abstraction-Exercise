using System;
using System.Linq;
using System.Collections.Generic;

namespace Task06_Food_Shortage
{
    public class Program
    {
        static void Main(string[] args)
        {

            int numbers = int.Parse(Console.ReadLine());
            List<IBuyer> people = new List<IBuyer>();

            for (int i = 1; i <= numbers; i++)
            {
                string[] nextDatas = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(nextDatas.Length == 4)
                {
                    Citizen nextCitizen = new Citizen(nextDatas[0], int.Parse(nextDatas[1]), nextDatas[2], nextDatas[3]);
                    people.Add(nextCitizen);
                }
                else
                {
                    Rebel nextRebel = new Rebel(nextDatas[0], int.Parse(nextDatas[1]), nextDatas[2]);
                    people.Add(nextRebel);
                }
            }

            while (true)
            {
                string nextName = Console.ReadLine();

                if(nextName.ToUpper() == "END")
                {
                    break;
                }

                IBuyer nextMan = people.FirstOrDefault(n => n.Name == nextName);

                if(nextMan != null)
                {
                    nextMan.BuyFood();
                }
            }

            int totalFood = 0;
            foreach (IBuyer element in people)
            {
                totalFood += element.Food;
            }

            Console.WriteLine(totalFood);

            //Console.WriteLine("Hello World!");
        }
    }
}
