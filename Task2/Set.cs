using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Set : Product
    {
        List<SubProduct> prod = new List<SubProduct>();
        public Set(string name, int price, List<SubProduct> products) : base(name, price)
        {
            prod = products;
        }

        public override void FindExpirationDate()
        {
            DateTime localTime = DateTime.Now;
            bool flag = false;
            foreach (var item in prod)
                if (DateTime.Compare(localTime, item.ExpireDate) > 0) flag = true;

            if (flag == true)
                Console.WriteLine("Срок годности вышел");
            else
                Console.WriteLine("Срок годности не вышел");

        }

        public override void PrintInfo()
        {
            Console.WriteLine($"""
               Товар : {Name}
               Цена : {Price}
               """);
            foreach (var item in prod) Console.WriteLine(item.Name + item.Price + item.DateOfProduct + item.ExpireDate);

        }
    }
}
