using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    internal class Hotel
    {
        public string Name { get; set; }
        public List<Person> Persons { get; set; }

        public Hotel(string name, List<Person> persons)
        {
            Name = name;
            Persons = persons;
        }
    }
}
