using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1ArrayList
{
    internal class Books_Actions
    {
        public static void AddBook(ArrayList books)
        {
            Console.WriteLine("Ввведите название книги");
            string name = Console.ReadLine();

            Console.WriteLine("Ввведите автора книги");
            string fio = Console.ReadLine();

            Console.WriteLine("Ввведите год книги");
            int year = Convert.ToInt32(Console.ReadLine());

            try
            {
                books.Add(new Book(name, fio, year));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
            }
        }

        public static void FindBook(ArrayList books)
        {
            Console.WriteLine("Ввведите автора книги");
            string fio = Console.ReadLine();
            bool flag = false;
            foreach (Book book in books)
                if (book.Fio.Equals(fio))
                {
                    Console.WriteLine(book.ToString());
                    flag = true;
                }

            if (flag == false) Console.WriteLine($"книг автора {fio} не найдено");
        }

        public static void DeleteBook(ArrayList books)
        {
            Console.WriteLine("Ввведите название книги");
            string name = Console.ReadLine();

            try
            {
                foreach (Book book in books)
                    if (book.Name.Equals(name))
                    {
                        books.Remove(book);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Книги с именем {name} не найдено");
                        break;
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка удаления: {ex.Message}");
            }
        }
    }
}
