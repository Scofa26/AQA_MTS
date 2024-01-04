using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    internal class Rectangle : Figure
    {
        int b;
        public Rectangle(int a, int b) : base(a)
        {
            this.b = b;
        }

        public override double Perimeter()
        {
            double P = 0;
            if (a != 0 && b != 0) P = a + b;
            return P;
        }

        public override double Square()
        {
            double S = 0;
            if (a != 0 && b != 0) S = a * b;
            return S;
        } 

        public override void PrintInfo()
        {
            double P = Perimeter(), S = Square();
            Console.WriteLine($"Площадь прямоугольника : {S}");
            Console.WriteLine($"Перметр прямоугольника : {P}");

        }
    }
}
