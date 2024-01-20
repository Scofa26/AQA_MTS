using LINQ.data;
using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Distinct
    {
       

        List<int> black_list = new List<int>() { -1, 3, 3, 6, 8, 12 };
       
        public void RunQuerySyntax()
        {
            // Query Syntax
            var queryResult2 =
               from i in black_list
               group i by i
               into result
               select new {  result.Key};
            PrintHelper.Print(queryResult2, item => Console.WriteLine($"person : {item}"));


        }

        public void RunMethodSyntax()
        {
            // Method Syntax
            Console.WriteLine("Method Syntax");

            var queryResult = black_list.Distinct();

            PrintHelper.Print(queryResult, item => Console.WriteLine($"Int : {item}"));

        }
    }
}
