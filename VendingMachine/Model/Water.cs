using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    class Water : Product
    {
        public int Capacity { get; set; }

        public string Type { get; set; }

        public Water(int id, string name, int price, int amount, int capacity, string type) : base(id, name, price, amount)
        {
            Capacity = capacity;
            Type = type;
        }

        public override string Info()
        {
            return $"--------Water-------\nId:{Id}\nName:{Name}\nPrice:{Price}\nAmount:{Amount}\nCapacity:{Capacity} ml\nType:{Type}\n";
        }

        public override string HowToUse()
        {
            return $"{Name}'s usage is to open the cap and drink directly";
        }
    }
}
