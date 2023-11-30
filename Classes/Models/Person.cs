using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Person
    {
        public string name = "Undefined";
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Print ()
        {
            Console.WriteLine($"Имя :{name} Возраст {age}");
        }

    }
}
