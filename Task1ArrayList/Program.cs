using System.Collections;
using Task1ArrayList;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList books = new ArrayList();

        books.Add(new Book("Золотой жук", "Эдгар Аллан По", 1843));
        books.Add(new Book("Отцы и дети", "Иван Тургенев", 1862));
        books.Add(new Book("Преступление и наказание", "Фёдор Достоевский", 1865));
        books.Add(new Book("Идиот", "Фёдор Достоевский", 1868));
        books.Add(new Book("Кому на Руси жить хорошо", "Николай Алексеевич Некрасов", 1865));
        books.Add(new Book("Русские женщины", "Николай Алексеевич Некрасов", 1871));

        Console.WriteLine(""" 
            Выберите действие: 
            1 - добавить книгу
            2 - просмотреть список книг 
            3 - поиск книги по автору 
            4 - удалить книгу 
            5 - выйти 
            """);

        while (true)
        {
            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Books_Actions.AddBook(books);
                    break;
                case 2:
                    Helper.PrintIfo(books);
                    break;
                case 3:
                    Books_Actions.FindBook(books);
                    break;
                case 4:
                    Helper.PrintIfo(books);
                    Books_Actions.DeleteBook(books);
                    break;
                case 5: Environment.Exit(0); break;
            }
        }
    }
}