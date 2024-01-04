using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal abstract class Product
    {
        string name;
        int price;

        protected Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public abstract void PrintInfo();
        public abstract void FindExpirationDate();
    }
}
