using Collections.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IDictionary
{
    internal class SortedListExample
    {
        public void Run()
        {
            // Создаем отсортированный список для строк (ключи) и int (значения)
            SortedList<string, int> mySortedList = new SortedList<string, int>();

            // Добавляем элементы в отсортированный список
            mySortedList.Add("Apple", 10);
            mySortedList.Add("Cherry", 7);
            mySortedList.Add("Banana", 5);

            // Выводим элементы отсортированного списка
            Console.WriteLine("SortedList elements:");
            PrintHelper.PrintCollection(mySortedList);

            // Проверяем наличие ключа в отсортированном списке
            bool containsKey = mySortedList.ContainsKey("Banana");
            Console.WriteLine($"ContainsKey(\"Banana\"): {containsKey}");

            // Проверяем наличие значение в отсортированном списке
            bool containsValue = mySortedList.ContainsValue(7);
            Console.WriteLine($"ContainsValue(\"Banana\"): {containsValue}");

            // Получаем значение по ключу
            int value;
            if (mySortedList.TryGetValue("Apple", out value))
            {
                Console.WriteLine($"Value for key 'Apple': {value}");
            }

            //Поиск индекса ключа 
            int index = mySortedList.IndexOfKey("Cherry");
            int value1 = mySortedList.GetValueAtIndex(index);   

            //Замена значения по индексу 
            mySortedList.SetValueAtIndex(index, 12);

            // Удаляем элемент по ключу
            mySortedList.Remove("Cherry");

            // Выводим элементы после удаления
            Console.WriteLine("SortedList elements after removal:");
            PrintHelper.PrintCollection(mySortedList);
        }
    }
}
