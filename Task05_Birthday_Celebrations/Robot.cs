using System;
using System.Collections.Generic;
using System.Text;

namespace Task05_Birthday_Celebrations
{
    public class Robot
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }

        public string Id { get; set; }

        public void priintId(string fake)
        {
            if (Id.EndsWith(fake))
            {
                Console.WriteLine($"{Id}");
            }
        }
    }
}
