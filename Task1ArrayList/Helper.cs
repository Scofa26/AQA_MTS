using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1ArrayList
{
    internal class Helper
    {
        public static void PrintIfo(System.Collections.IList list)
        {
            Console.WriteLine("Список книг:");

            foreach (Book item in list)
            {
               Console.WriteLine(item.ToString());
               Console.WriteLine();
            }
        }
    }
}
