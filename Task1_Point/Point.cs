using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Point
{
    internal class Point<T>
    {
         T x, y;
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public T X { get => x; set => x = value; }
        public T Y { get => y; set => y = value; }
        public void Print()
        {
            Console.WriteLine($"x = {X} y = {Y}");
        }
    }
}
