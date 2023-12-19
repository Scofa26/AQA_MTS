using Collections.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ISet
{
    internal class HashSetExample
    {
        public void Run()
        {
            // Создание HashSet для строк
            HashSet<string> uniqueNames = new HashSet<string>();

            // Добавление элементов
            uniqueNames.Add("Alice");
            uniqueNames.Add("Bob");
            uniqueNames.Add("Alice"); // Этот элемент не добавится, так как "Alice" уже существует

            // Вывод элементов
            Console.WriteLine("Unique Names:");
            PrintHelper.PrintCollection(uniqueNames);

            // Проверка наличия элемента
            bool containsBob = uniqueNames.Contains("Bob");
            Console.WriteLine($"Contains 'Bob': {containsBob}");

            HashSet<string> exeptNames = new HashSet<string>();

            // Добавление элементов
            uniqueNames.Add("Alice");
            uniqueNames.Add("Bob1");
            uniqueNames.Add("Alice"); // Этот элемент не добавится, так как "Alice" уже существует

            var differ = uniqueNames.Except(exeptNames);
            Console.WriteLine("\n Names afet exept");
            PrintHelper.PrintCollection(differ);

            uniqueNames.ExceptWith(exeptNames);
            Console.WriteLine("\n Names after exeptWith");
            PrintHelper.PrintCollection(differ);

            // Удаление элемента
            uniqueNames.Remove("Alice");

            // Вывод элементов после удаления
            Console.WriteLine("\nNames after removal:");
            PrintHelper.PrintCollection(uniqueNames);
        }

    }
}
