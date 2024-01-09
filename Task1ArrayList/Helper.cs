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
            foreach (Book item in list)
            {
                item.ToString();
            }
        }
    }
}
