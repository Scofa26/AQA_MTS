using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HW
{
    internal class PrintHelper
    {
        public static void Print<T>(IEnumerable<T> source, Action<T> action)
        {
            foreach(T item in source) { action(item); }
        }
    }
}
