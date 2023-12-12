using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Figures.Models
{
    public  class Figure
    {
        int a; // определила какое-то 1 базовое поле, отвечающее за сторону фигуры

        public int A { get => a; set => a = value; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Сторны : {a}");
        }
        public virtual void Square() { } 
    }
}
