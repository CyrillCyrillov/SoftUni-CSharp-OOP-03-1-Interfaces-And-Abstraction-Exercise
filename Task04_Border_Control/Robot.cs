using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Border_Control
{
    public class Robot : IControlible
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
