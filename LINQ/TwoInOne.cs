using LINQ.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class TwoInOne
    {
        public void run()
        {
            TestIntSet testSet = new TestIntSet();

            // Query Syntax + Method Syntax
            Console.WriteLine("Two in One");

            // Count
            int countResult =
                (from number in testSet
                 where number % 2 == 0
                 select number).Count();

            Console.WriteLine($"{countResult}");

            int maxResult =
                (from number in testSet
                 where number % 2 == 0
                 select number).Max();

            Console.WriteLine($"{maxResult}");
        }
    }
}
