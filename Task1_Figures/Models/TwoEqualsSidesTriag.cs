using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1_Figures.Models
{
    public class TwoEqualsSidesTriag : Triangle
    {
        public TwoEqualsSidesTriag(int a, int c)
        {
            this.A = a;
            this.C = c; 
        }

        public override void Square()
        {
            double square = 0;
            square = Math.Sqrt(4*A*A - C*C) * (C / 4.0);
            Console.WriteLine($"S = {square}");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($" {C}");
        }
    }
}
