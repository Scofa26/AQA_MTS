using LINQ.data;
using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class DataAgregation
    {
        private TestIntSet _testIntSet = new TestIntSet();
        private TestStringSet _testStringSet = new TestStringSet();
        private TestObjectSet _testObjectSet = new TestObjectSet();

        public void RunQuerySyntax()
        {
            // Query Syntax
            Console.WriteLine("Query Syntax");

            //Создание временных переменных
            var queryResult =
                from hotel in _testObjectSet.List
                from person in hotel.Persons
                select person;
            PrintHelper.Print(queryResult, item => Console.WriteLine($"Person : {item}"));
        }

        public void RunMethodSyntax()
        {
            // Method Syntax
            Console.WriteLine("Method Syntax");

            var queryResult = _testObjectSet.List.SelectMany(hotel => hotel.Persons);

               
            PrintHelper.Print(queryResult, item => Console.WriteLine($"Person : {item}"));


        }
    }
}
