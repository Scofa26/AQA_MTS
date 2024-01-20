using LINQ.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class SkipTake
    {
        private TestIntSet _testIntSet = new TestIntSet();
        private TestStringSet _testStringSet = new TestStringSet();
        private TestObjectSet _testObjectSet = new TestObjectSet();

        public void RunQuerySyntax()
        {
            // Query Syntax
            Console.WriteLine("Query Syntax");
          
        }

        public void RunMethodSyntax()
        {
            // Method Syntax
            Console.WriteLine("Method Syntax");

            //Skip
            Console.WriteLine("Skip");
            var queryResult = _testStringSet.List.Skip(2);

            Console.WriteLine("SkipLast");
            var queryResult1 = _testStringSet.List.SkipLast(2);

            Console.WriteLine("SkipWhile");
            var queryResult2 = _testStringSet.List.SkipWhile(p=> p.Length==3);

            //Take 
            Console.WriteLine("Take");
            var queryResult3 = _testStringSet.List.Take(2);

            Console.WriteLine("TakeLast");
            var queryResult4 = _testStringSet.List.TakeLast(2);

            Console.WriteLine("TakeWhile");
            var queryResult5 = _testStringSet.List.TakeWhile(p => p.Length == 3);
        }
    }
}
