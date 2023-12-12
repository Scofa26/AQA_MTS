using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Figures.Models
{
    public class Creator
    {
        public static Triangle Create(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && a == c)
                {
                    Console.WriteLine("Равносторонний треугольник");
                    return new ThreeEqualsSidesTriag(a);
                }
                else if (a == b)
                {
                    Console.WriteLine("Равнобедренный треугольник");
                    return new TwoEqualsSidesTriag(a, c);
                }
                else if (a == c)
                {
                    Console.WriteLine("Равнобедренный треугольник");
                    return new TwoEqualsSidesTriag(a, b);
                }
                else if (b == c)
                {
                    Console.WriteLine("Равнобедренный треугольник");
                    return new TwoEqualsSidesTriag(b, a);
                }
                else if (c * c == a * a + b * b)
                {
                    Console.WriteLine("Прямоугольный треугольник");
                    return new RectengularTriag(a, b, c);
                }
                else if (b * b == c * c + b * b)
                {
                    Console.WriteLine("Прямоугольный треугольник");
                    return new RectengularTriag(a, c, b);
                }
                else if (a * a == b * b + c * c)
                {
                    Console.WriteLine("Прямоугольный треугольник");
                    return new RectengularTriag(c, b, a);
                }
                else return new AllSidesAreDifferentTriag(a, c, b);
            }
            else
            {
                throw new Exception("Данные стороны не могут образовать треугольник");
            }
        }
    }
}
