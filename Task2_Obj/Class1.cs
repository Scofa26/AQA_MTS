using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2_Obj
{
    internal class Class1<T>
    {
        T[] items;
        int size;

        public Class1(int size)
        {
            items = new T[size];
            this.size = size;
        }

        public int Size { get => size; set => size = value; }
        public T[] Items { get => items; set => items = value; }

        public void Add(T item)
        {
            Array.Resize(ref items, size + 1);
            items[size - 1] = item;
            size++;
        }

        public void Remove(T item)
        {
            List<T> list = items.ToList<T>();
            list.Remove(item);
            items = list.ToArray();
        }

        public void Search(int index)
        {
            for (int i = 0; i < size; i++)
                if (i == index) Console.WriteLine($"Найденный элемент {Items[i]} с индексом {index}");
        }

        public int GetLenght()
        {
            return items.Length;
        }

        public void Print<T>(T[] values)
        {
            for (int i = 0; i < values.Length ; i++) Console.WriteLine(values[i]);
        }
    }
}
