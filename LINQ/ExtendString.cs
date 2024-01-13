using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal static class ExtendString
    {
        public static char GetChar(this string value, int index)
        {
            return value[index];
        }
    }
}
