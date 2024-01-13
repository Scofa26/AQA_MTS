using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Dictionary
{
    internal class Product
    {
        string name;
        double price;
        int count;

        public Product(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }

        public override string? ToString()
        {
            return $"""
                Название : {name}
                Цена : {price}
                Кол-во : {count}
                """;
        }
    }
}
