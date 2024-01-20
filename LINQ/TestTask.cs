﻿using LINQ.data;
using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class TestTask
    {
        private TestObjectSet _testObjectSet = new();

        public void Solve()
        {
            List<Person> expectedList = new List<Person>();

            foreach (Person person in _testObjectSet)
            {
                if (person.Age == 45)
                {
                    expectedList.Add(person);
                }
            }

            Console.WriteLine(expectedList.Count());

            Console.WriteLine(_testObjectSet.Where(obj => obj.Age == 45).Select(obj => obj).Count());
        }
    }

}