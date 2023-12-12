using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Figures.Models
{
    public class Rectangle : Figure
    {
        int b;

        public Rectangle(int a, int b)
        {
            this.A = a;
            this.b = b;
        }
        public override void Square()
        {
            double square = 0;
            square = A * b;
            Console.WriteLine($"S = {square}");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($" {b}");
        }
    }
}
