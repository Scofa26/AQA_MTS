using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IList
{
    internal class ArrayListExample
    {
        public void Run() { 
            ArrayList stringList = new ArrayList();
            // Добавляем элементы в ArrayList
            
            stringList.Add("Первый");
            stringList.Add("Второй");
            stringList.Add("Третий");
            stringList.Add("Третий");
            Console.WriteLine(stringList.Capacity);


            // Создаем ArrayList для хранения строк в С# 12
            ArrayList stringList1 =
            [
                "Первый",
                2,
                false,
                new StringBuilder("Object")
            ];

            // Выводим элементы ArrayList
            Console.WriteLine("Элементы в ArrayList:");
            // foreach (string item in stringList1) // Ошибка
            foreach (var item in stringList) // Рекомендуемый вариант
            {
                Console.WriteLine(item);
            }

            // Добавляем элементы в ArrayList с разными типами данных
            stringList.Add(4); // Допустимо, но не рекомендуется
            stringList.Add(true); // Допустимо, но не рекомендуется
            stringList.Add(new StringBuilder("Object")); // Допустимо, но не рекомендуется

            // Выводим элементы после добавления разных типов данных
            Console.WriteLine("\nЭлементы в ArrayList после добавления числа и булевого значения:");
        }
    }
}
