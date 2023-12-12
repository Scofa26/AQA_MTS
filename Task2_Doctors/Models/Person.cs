using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Doctors.Models
{
    public class Person
    {
        string fio;

        public Person(string fio)
        {
            this.fio = fio;
        }

        public string Fio { get => fio; set => fio = value; }
        public void PrintInfo()
        {
            Console.WriteLine($"ФИО: {fio}");
        }
    }
}
