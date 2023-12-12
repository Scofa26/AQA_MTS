using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Figures.Models
{
    public class SquareF : Figure
    {
        public SquareF(int a)
        {
            this.A = a;
        }

        public override void Square()
        {
            double square = 0;
            square = A * A;
            Console.WriteLine($"S = {square}");
        }
    }
}
