using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    abstract class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public int Price { get; set; }

        public abstract string Info();

        public abstract string HowToUse();

        public Product(int id, string name, int amount, int price)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id:{Id}\tName:{Name}\tPrice:{Price}\tAmount:{Amount}";
        }



    }
}
