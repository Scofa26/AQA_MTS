using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    internal class Circle : Figure
    {
        public Circle(int a) : base(a)
        {
        }

        public override double Perimeter()
        {
            double C = 0;
            C = 2 * a * Math.PI;
            return C;
        }

        public override double Square()
        {
            double S = 0;
            S = Math.PI * a * a;
            return S;
        }

        public override void PrintInfo()
        {
            double C = Perimeter(), S = Square();
            Console.WriteLine($"Длина окружности : {C}");
            Console.WriteLine($"Площадь круга : {S}");
        }
    }
}
