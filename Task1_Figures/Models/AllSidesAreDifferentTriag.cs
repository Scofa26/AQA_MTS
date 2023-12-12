using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Figures.Models
{
    public class AllSidesAreDifferentTriag : Triangle
    {
        public AllSidesAreDifferentTriag(int a, int b, int c)
        {
            this.A = a; 
            this.B = b;
            this.C = c; 
        }

        public override void Square()
        {
            double square = 0, p = P();
            square = Math.Sqrt(p*(p-A)*(p-B)*(p-C));
            Console.WriteLine($"S = {square}");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($"{B}, {C}");
        }
    }
}
