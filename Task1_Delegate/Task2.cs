using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Task2
    {
        public delegate double RunMeth(double r);
        public void Run(double r)
        {
            RunMeth runMeth = C;
            runMeth += S;
            runMeth += V;
            runMeth.Invoke(r); 
        }

        public double C (double r)
        {
            double c = 2 * Math.PI * r;
            Console.WriteLine($"C = {c}");
            return c;
        }
        
        public double S (double r)
        {
            double s = Math.PI * r * r;
            Console.WriteLine($"S = {s}");
            return s;
        }

        public double V (double r)
        {
            double v = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"V = {v}");
            return v;
        }
    }
}
