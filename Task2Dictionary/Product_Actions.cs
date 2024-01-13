using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Dictionary
{
    internal class Product_Actions
    {
        public static void AddProduct(Dictionary<Guid, Product> products)
        {
            Guid id = Guid.NewGuid();
            Console.WriteLine("Ввведите название продукта");
            string name = Console.ReadLine();

            Console.WriteLine("Ввведите цену продукта");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ввведите цену продукта");
            int count = Convert.ToInt32(Console.ReadLine());

            try
            {
                products.Add(id, new Product(name, price, count));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
            }
        }

        public static void FindProduct(Dictionary<Guid, Product> products)
        {
            Console.WriteLine("Ввведите id");
            Guid id = new Guid(Console.ReadLine());
            bool flag = false;

            foreach (var product in products)
                if (product.Key.Equals(id))
                {
                    Console.WriteLine(product.ToString());
                    flag = true;
                }

            if (flag == false) Console.WriteLine($"Продукта с id {id} не найдено");
        }

        public static void UpdateProduct(Dictionary<Guid, Product> products)
        {
            Console.WriteLine("Ввведите id товара, котрый нужно изменить");
            Guid id = new Guid(Console.ReadLine());

            Console.WriteLine("""
                1-изменить цену
                2-изменить кол-во
                """);
            try
            {
                int oper = Convert.ToInt32(Console.ReadLine());
                bool flag = false;
                foreach (var product in products)
                    if (product.Key.Equals(id))
                    {
                        if (oper == 1) { product.Value.Price = Convert.ToDouble(Console.ReadLine()); Console.WriteLine(product.ToString()); }
                        else if (oper == 2) { product.Value.Count = Convert.ToInt32(Console.ReadLine()); Console.WriteLine(product.ToString()); }
                        else Console.WriteLine($"Операции с номером {oper} нет");
                        flag = true;
                        break;
                    }

                if (flag == false) Console.WriteLine($"Продукта с id {id} не найдено");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода операции: {ex.Message}");
            }
           
        }

        public static void DeleteProduct(Dictionary<Guid, Product> products)
        {
            Console.WriteLine("Ввведите название товара");
            string name = Console.ReadLine();
            bool flag = false;
            try
            {
                foreach (var product in products)
                    if (product.Value.Name.Equals(name))
                    {
                        products.Remove(product.Key);
                        flag = true;
                        break;
                    }
                if (flag == false) Console.WriteLine($"Продукт с именем {name} не найден");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка удаления: {ex.Message}");
            }
        }

    }
}
