using LINQ_HW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HW
{
    internal class Task3
    {
        private TestStringSet testStringSet = new TestStringSet();

        public void Method()
        {
            PrintHelper.Print(testStringSet.List, i => Console.WriteLine($"testStringSet = {i}"));

            var result = testStringSet.List.OrderBy(x => x.Length).ThenByDescending(x => x);
            PrintHelper.Print(result, i => Console.WriteLine($"result = {i}"));
        }
    }
}
