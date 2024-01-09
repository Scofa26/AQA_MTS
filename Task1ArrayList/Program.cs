internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("""
            1 - добавить книгу
            2 - просмотреть список книг 
            3 - поиск книги по автору 
            4 - удалить книгу 
            5 - выйти 
            """);
        int action = Convert.ToInt32(Console.ReadLine());
        switch (action) { 
            case 1: Console.WriteLine();
                break;
                case 2: Console.WriteLine(); break; 
                case 3: Console.WriteLine(); break;
                case 4: Console.WriteLine(); break; 
                case 5: Console.WriteLine(); break;
            default:
                Console.WriteLine(); break;
                    


        }
    }
}