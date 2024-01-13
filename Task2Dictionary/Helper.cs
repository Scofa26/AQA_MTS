using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Dictionary
{
    internal class Helper
    {
        public static void PrintInfo(Dictionary<Guid, Product> dictionary)
        {
            Console.WriteLine("Список продуктов:");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}
