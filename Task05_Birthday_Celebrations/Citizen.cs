using System;
using System.Collections.Generic;
using System.Text;

namespace Task05_Birthday_Celebrations
{
    class Citizen : ICelebrateble
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

        public string Birthdate { get; set; }

        public void priintId(string fake)
        {
            if(Id.EndsWith(fake))
            {
                Console.WriteLine($"{Id}");
            }
        }

        public void Printcelebrating(string year)
        {
            if(Birthdate.EndsWith(year))
            {
                Console.WriteLine(Birthdate);
            }
        }
    }
}
