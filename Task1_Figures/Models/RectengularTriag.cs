using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Figures.Models
{
    public class RectengularTriag : Triangle
    {
        public RectengularTriag(int a, int b, int c)
        {
            this.A = a; 
            this.B = b; 
            this.C = c;
        }

        public override void Square()
        {
            double square = 0;
            square = A * B * 0.5;
            Console.WriteLine($"S = {square}");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($"{B}, {C}");
        }

    }
}
