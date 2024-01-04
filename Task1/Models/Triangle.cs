using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    internal class Triangle : Figure
    {
        int b, c;
        public Triangle(int a, int b, int c) : base(a)
        {
            this.b = b;
            this.c = c;
        }
        public override double Perimeter()
        {
            double P = 0;
            if (a != 0 && b != 0 && c != 0) P = a + b + c;
            return P;
        }

        public override double Square()
        {
            double  S = 0, p = Perimeter()/2.0;
            if (a + b > c && a + c > b && b + c > a) S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return S;
        }

        public override void PrintInfo()
        {
            double P = Perimeter(), S = Square();
            Console.WriteLine($"Периметр треугольника : {P}");
            Console.WriteLine($"Площадь треугольника : {S}");
        }
    }
}
