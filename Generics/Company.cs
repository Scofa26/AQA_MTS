using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Company<P>
    {
        public P CEO { get; set; } // президент компании

        public Company(P ceo)
        {
            CEO = ceo;
        }
    }
}
