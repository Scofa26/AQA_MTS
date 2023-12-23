using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class StaticPerson<T>
    {
        public static T? code;

        public T Id { get; set; }
        public string Name { get; }

        public StaticPerson(T id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }
    }
}
