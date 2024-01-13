using Task2Dictionary;
using static System.Reflection.Metadata.BlobBuilder;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<Guid, Product> products = new Dictionary<Guid, Product>
        {
            { Guid.NewGuid(), new Product("яблоко", 120, 10) },
            { Guid.NewGuid(), new Product("апельсин", 60, 40) },
            { Guid.NewGuid(), new Product("мандарин", 34, 50) },
            { Guid.NewGuid(), new Product("груша", 14, 16) },
            { Guid.NewGuid(), new Product("арбуз", 220, 5) }
        };
        Console.WriteLine(""" 
            Выберите действие: 
            1 - добавить продукт
            2 - просмотреть список продуктов 
            3 - поиск продукта по id
            4 - обновить ценц или кол-во
            5 - удалить продукт
            6 - выйти 
            """);

        while (true)
        {
            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Product_Actions.AddProduct(products);
                    break;
                case 2:
                    Helper.PrintInfo(products);
                    break;
                case 3:
                    Product_Actions.FindProduct(products);
                    break;
                case 4:
                    Product_Actions.UpdateProduct(products);
                    break;
                case 5:
                    Product_Actions.DeleteProduct(products);
                    break;
                case 6: Environment.Exit(0); break;
            }
        }
    }
}