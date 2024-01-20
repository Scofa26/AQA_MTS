using LINQ.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Union
    {
        private TestIntSet _testIntSet = new TestIntSet();
        private TestStringSet _testStringSet = new TestStringSet();
        private TestObjectSet _testObjectSet = new TestObjectSet();

        List<int> black_list = new List<int>() { -1, -3, 3, 6, 8, 12 };
        public void RunQuerySyntax()
        {
            // НЕТ запроса 
           

        }

        public void RunMethodSyntax()
        {
            // Method Syntax
            Console.WriteLine("Method Syntax");

            var queryResult = _testIntSet.Union(black_list);

            PrintHelper.Print(queryResult, item => Console.WriteLine($"Int : {item}"));

        }
    }
}

