using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Student
    {
        public string name;
        public int group;
        public int diplomMark;

        public Student()
        {
         
        }
        public Student(string name)
        {
            this.name = name;
            group = 1;
            diplomMark = new Random().Next(1, 11);

        }

        public void Print()
        {
            Console.WriteLine($"{name} + {group} + {diplomMark}");
            Console.WriteLine();

        }
    }
}
