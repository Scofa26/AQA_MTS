using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    internal abstract class Figure
    {
        public int a; // сторона или радиус 

        protected Figure(int a)
        {
            this.a = a;
        }

        public abstract double Square();
        public abstract double Perimeter();
        public abstract void PrintInfo();
        public double Sum()
        {
            double S = Square(), P = Perimeter(), Sum = S + P;
            return Sum;
        }
    }
}
