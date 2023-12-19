using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Example
    {
        public void Run()
        {
            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();

            students.Add("Sasha", new List<int> { 7, 9, 10 });
            students.Add("Masha", new List<int> { 10, 9, 10,8 });
            students.Add("Stas", new List<int> { 10, 9, 10,8 });

            foreach (var student in students)
            {
               var averagemarks= student.Value.Average();
                Console.WriteLine($"Средняя оценка = {averagemarks}");
            }

        }
    }
}
