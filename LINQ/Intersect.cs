﻿using LINQ.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Intersect
    {
        private TestIntSet _testIntSet = new TestIntSet();
        private TestStringSet _testStringSet = new TestStringSet();
        private TestObjectSet _testObjectSet = new TestObjectSet();

        List<int> black_list = new List<int>() { -1, -3, 3, 6, 8, 12 };
        public void RunQuerySyntax()
        {
            // Query Syntax
            Console.WriteLine("Query Syntax");
            var queryResult =
                 from number in _testIntSet
                 where black_list.Contains(number)
                 select number;

            PrintHelper.Print(queryResult, item => Console.WriteLine($"Int : {item}"));

        }

        public void RunMethodSyntax()
        {
            // Method Syntax
            Console.WriteLine("Method Syntax");

            var queryResult = _testIntSet.Intersect(black_list);

            PrintHelper.Print(queryResult, item => Console.WriteLine($"Int : {item}"));

        }
    }
}

