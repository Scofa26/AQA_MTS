using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1ArrayList
{
    internal class Book
    {
        string name, fio;
        int year;

        public Book(string name, string fio, int year)
        {
            this.name = name;
            this.fio = fio;
            this.year = year;
        }

        public override string? ToString()
        {
            return $"""
                Название : {name} 
                Автор : {fio}
                Год : {year}
                """ ;
        }
    }
}
