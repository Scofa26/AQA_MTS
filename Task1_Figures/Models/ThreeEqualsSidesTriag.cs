using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Figures.Models
{
    public class ThreeEqualsSidesTriag : Triangle
    {
        public ThreeEqualsSidesTriag(int a)
        {
            this.A = a;
        }

        public override void Square()
        {
            double square = 0;
            square = A * A * (Math.Sqrt(3) / 4.0);
            Console.WriteLine($"S = {square}");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Сторона равностороннего треугольника : {A}");
        }
    }
}
