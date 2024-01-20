using LINQ.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class OrderBy
    {
        private TestIntSet _testIntSet = new TestIntSet();
        private TestStringSet _testStringSet = new TestStringSet();
        private TestObjectSet _testObjectSet = new TestObjectSet();

        public void RunQuerySyntax()
        {
            // Query Syntax
            Console.WriteLine("Query Syntax");
            var queryResult =
                from i in _testIntSet
                orderby i descending
                select i;
            PrintHelper.Print(queryResult, item => Console.WriteLine($"Int : {item}"));

           
            var queryResult1 =
                from text in _testStringSet.List
                orderby text
                select text;
            PrintHelper.Print(queryResult, item => Console.WriteLine($"String : {item}"));

            //Двойн6ая сортировка 
            var queryResult2 =
               from person in _testObjectSet
               orderby person.Age,  person.Name descending
               select person;
            PrintHelper.Print(queryResult, item => Console.WriteLine($"person : {item}"));
        }

        public void RunMethodSyntax()
        {
            // Method Syntax
            Console.WriteLine("Method Syntax");

            var queryResult = _testIntSet.OrderBy(number => number);
               
            PrintHelper.Print(queryResult, item => Console.WriteLine($"Int : {item}"));

            var queryResult1 = _testStringSet.List.OrderBy(text => text);
            PrintHelper.Print(queryResult, item => Console.WriteLine($"String : {item}"));

            var queryResult2 = _testObjectSet.OrderBy(person => person.Age).ThenByDescending(person => person.Name);
            PrintHelper.Print(queryResult, item => Console.WriteLine($"person : {item}"));
       
       


        }
    }
}
