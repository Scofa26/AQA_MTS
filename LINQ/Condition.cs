using LINQ.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Condition
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
            //All - проверка на условие 
            bool allResult = _testStringSet.List.All(text => text.Length < 7);

            //Any 
            bool allResult1 = _testStringSet.List.Any(text => text.Length == 3);

            //Contains

        }
    }
}
