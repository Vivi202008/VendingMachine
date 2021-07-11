using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    class Chocolate:Product
    {
        public int Weight { get; set; }

        public string Type { get; set; }

        public Chocolate (int id, string name, int price, int amount, int weight, string type) : base(id, name, price, amount)
        {
            Weight = weight;
            Type = type;
        }

        public override string Info()
        {
            return $"--------Chocolate-------\nId:{Id}\nName:{Name}\nPrice:{Price}\nAmount:{Amount}\nWeight:{Weight } g\nType:{Type}\n";
        }

        public override string HowToUse()
        {
            return $"{Name}'s usage is to eat directly after opening the package";
        }
    }
}
