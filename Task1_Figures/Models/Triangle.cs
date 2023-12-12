using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Figures.Models
{
    public  class Triangle : Figure
    {
        int b ,c;

        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Стороны треугольника : {A}, {b}, {c}");
        }

        public double P() {
            double p;
            p = (A + b + c) * 0.5;
            return p;   
        } 
    }
}
