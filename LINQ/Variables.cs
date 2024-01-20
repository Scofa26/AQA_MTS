using LINQ.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Variables
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
                from person in _testObjectSet
                let yearOfBirth = DateTime.Now.Year - person.Age
                let flag = true
                select new
                {
                    FirstName = person.Name,
                    YearOfBirth = yearOfBirth,
                    Flag = flag
                };
            PrintHelper.Print(queryResult, item => Console.WriteLine($"Person : {item}"));
        }

        public void RunMethodSyntax()
        {
            // Method Syntax
            Console.WriteLine("Method Syntax");

            var queryResult = _testObjectSet
                .Select(person => new { person.Name, YearOfBirth = DateTime.Now.Year - person.Age });
            PrintHelper.Print(queryResult, item => Console.WriteLine($"Person : {item}"));


        }
    }
}

