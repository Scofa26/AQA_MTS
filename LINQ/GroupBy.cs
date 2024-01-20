using LINQ.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class GroupBy
    {
        private TestIntSet _testIntSet = new TestIntSet();
        private TestStringSet _testStringSet = new TestStringSet();
        private TestObjectSet _testObjectSet = new TestObjectSet();

        public void RunQuerySyntax()
        {
           
            var queryResult2 =
               from person in _testObjectSet
               group person by person.Age
               into result
               select new { GroupName = result.Key, Count = result.Count()};
            PrintHelper.Print(queryResult2, item => Console.WriteLine($"person : {item}"));
        }

        public void RunMethodSyntax()
        {
            // Method Syntax
            Console.WriteLine("Method Syntax");

            var queryResult2 = _testObjectSet
                .GroupBy(person => person.Age)
                .Select(result => new { GroupName = result.Key, Count = result.Count() });
               
            PrintHelper.Print(queryResult2, item => Console.WriteLine($"person : {item}"));

        }
    }
}
