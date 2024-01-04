using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Batch : SubProduct
    {
       
        int count;
        public Batch(string name, int price, int count, DateTime dateOfProduct, DateTime expireDate) : base(name, price, dateOfProduct, expireDate)
        {
            this.count = count;
        }

        public override void PrintInfo()
        {
            base.PrintInfo(); 
            Console.WriteLine($"Количество : {count}");
        }
    }
}
