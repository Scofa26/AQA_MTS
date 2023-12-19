using Collections.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IList
{
    internal class QueueExample
    {
        public void Run()
        {
            public void Run()
            {
                // Создаем очередь для строк
                Queue<string> myQueue = new Queue<string>();

                // Добавляем элементы в очередь
                myQueue.Enqueue("Apple");
                myQueue.Enqueue("Banana");
                myQueue.Enqueue("Cherry");

                // Выводим элементы очереди
                Console.WriteLine("Queue elements:");
                PrintHelper.PrintCollection(myQueue);

                // Получаем и удаляем элемент из начала очереди
                string dequeuedElement = myQueue.Dequeue();
                Console.WriteLine($"Dequeued element: {dequeuedElement}");

                // Выводим элементы после извлечения
                Console.WriteLine("Queue elements after dequeue:");
                PrintHelper.PrintCollection(myQueue);

                // Проверяем элемент в начале очереди без удаления
                string peekedElement = myQueue.Peek();
                Console.WriteLine($"Peeked element: {peekedElement}");

                // Выводим элементы после просмотра
                Console.WriteLine("Queue elements after peek:");
                PrintHelper.PrintCollection(myQueue);
            }
        }
}
