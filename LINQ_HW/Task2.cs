using LINQ_HW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HW
{
    internal class Task2
    {
        private TestObjectSet testObjectSet = new TestObjectSet();

        public void Method()
        {
            PrintHelper.Print(testObjectSet, i => Console.WriteLine($"testObjectSet = {i}"));
            var min = testObjectSet.Min(p => p.Duration);
            var tmp = testObjectSet.Select(client => new { Duration = client.Duration, Year = client.Year, Month = client.MonthNum }).LastOrDefault(c => c.Duration == min);

            Console.WriteLine(tmp);
        }
    }
}
