using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    class Toy:Product
    {
        public int AgeLimit{ get; set; }

        public string Matieral { get; set; }

        public Toy(int id, string name, int price, int amount, int ageLimit, string matieral) : base(id, name, price, amount)
        {
            Matieral = matieral;
            AgeLimit = ageLimit;
        }

        public override string Info()
        {
            return $"--------Toy-------\nId:{Id}\nName:{Name}\nPrice:{Price}\nAmount:{Amount}\nMatieral:{Matieral}\nAgeLimit:over {AgeLimit} years old\n";
        }

        public override string HowToUse()
        {
            return $"{Name}'s usage is to give chilrden older than 3 years old after opening the package";
        }
    }
}
