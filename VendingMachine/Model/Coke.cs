using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    class Coke : Product
    {
        public int Capacity{get;set;}

        public string CanOrBottle { get; set; }

        public Coke(int id,string name,int price,int amount, int capacity, string canOrBottle) : base(id, name, price, amount)
        {
            Capacity = capacity;
            CanOrBottle = canOrBottle;
        }

        public override string Info()
        {
            return $"--------Coke-------\nId:{Id}\nName:{Name}\nPrice:{Price}\nAmount:{Amount}\nCapacity:{Capacity} ml\nCanOrBottles:{CanOrBottle}\n";
        }

        public override string HowToUse()
        {
            return $"{Name}'s usage is to open the cap and drink directly";
        }
    }
}
