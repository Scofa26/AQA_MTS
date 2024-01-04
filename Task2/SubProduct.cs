using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class SubProduct : Product
    {
        DateTime dateOfProduct = new DateTime();
        DateTime expireDate = new DateTime();

        public SubProduct(string name, int price, DateTime dateOfProduct, DateTime expireDate) : base(name, price)
        {
            this.dateOfProduct = dateOfProduct;
            this.expireDate = expireDate;
        }

        public DateTime DateOfProduct { get => dateOfProduct; set => dateOfProduct = value; }
        public DateTime ExpireDate { get => expireDate; set => expireDate = value; }

        public override void FindExpirationDate()
        {
            DateTime localTime = DateTime.Now;
            int res = DateTime.Compare(localTime, expireDate);

            if (res > 0)
                Console.WriteLine("Срок годности вышел");
            else 
                Console.WriteLine("Срок годности не вышел");
        }

        public override void PrintInfo()
        {
           Console.WriteLine($"""
               Товар : {Name}
               Цена : {Price}
               Дата производства : {dateOfProduct}
               Годен до : {expireDate}
               """);
        }
    }
}
