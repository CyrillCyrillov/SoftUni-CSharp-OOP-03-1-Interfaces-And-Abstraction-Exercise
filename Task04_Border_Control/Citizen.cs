using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Border_Control
{
    class Citizen : IControlible
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

        public void priintId(string fake)
        {
            if(Id.EndsWith(fake))
            {
                Console.WriteLine($"{Id}");
            }
        }
    }
}
