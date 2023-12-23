using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericPerson<T>
    {
        public T Id { get; set; }   
        public string Name { get; set; }

        public GenericPerson(T id, string name)
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
