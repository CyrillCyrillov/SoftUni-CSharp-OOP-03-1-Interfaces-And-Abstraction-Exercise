using System;
using System.Collections.Generic;
using System.Text;

namespace Task05_Birthday_Celebrations
{
    public class Pet : ICelebrateble
    {

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
        
        public string Name { get; set; }
        
        public string Birthdate { get; set; }

        public void Printcelebrating(string year)
        {
            if (Birthdate.EndsWith(year))
            {
                Console.WriteLine(Birthdate);
            }
        }
    }
}
