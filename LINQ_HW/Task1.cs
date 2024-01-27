﻿using LINQ_HW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HW
{
    internal class Task1
    {
        private TestIntSet testintset = new TestIntSet();

        public void Method()
        {
            //Извлечь все нечетные. Сохранить исходный порядок следования. Удалить все вхождения повторяющихся эл-ов
            PrintHelper.Print(testintset, i => Console.WriteLine($"testintset = {i}"));
            var result = testintset.Where(num => num % 2 == 1).Distinct().Select(num => num);

            PrintHelper.Print(result, i => Console.WriteLine($"result = {i}"));
        }
    }
}
