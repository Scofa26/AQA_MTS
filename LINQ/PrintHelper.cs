using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class PrintHelper
    {
        public static void Print<T>(IEnumerable<T> array, Action<T> action)
        {
            foreach (T item in array)
            {
                action(item);
            }
        }
    }
}
