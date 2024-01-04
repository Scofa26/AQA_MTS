using System.Diagnostics;
using System.Xml.Linq;
using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        SubProduct[] product = new SubProduct[5];

        product[0] = new SubProduct("яблоко", 25, new DateTime(2023, 12, 3, 18, 30, 12), new DateTime(2024, 03, 4, 18, 30, 12));
        product[1] = new SubProduct("апельсин", 40, new DateTime(2024, 01, 4, 18, 30, 12), new DateTime(2024, 02, 5, 18, 30, 12));
        product[2] = new SubProduct("слива", 15, new DateTime(2024, 01, 5, 18, 30, 12), new DateTime(2024, 05, 4, 18, 30, 12));
        product[3] = new SubProduct("груша", 30, new DateTime(2024, 01, 1, 18, 30, 12), new DateTime(2024, 02, 4, 18, 30, 12));
        product[4] = new SubProduct("дыня", 100, new DateTime(2023, 12, 3, 18, 30, 12), new DateTime(2023, 01, 1, 18, 30, 12));

        foreach (var item in product)
        {
            item.PrintInfo();
            item.FindExpirationDate();
        }
           
        Set[] set = new Set[3];

        set[0] = new Set("набор фруктов 1", 1250, new List<SubProduct> { product[0], product[1] });
        set[1] = new Set("набор фруктов 2", 2250, new List<SubProduct> { product[2], product[3] });
        set[2] = new Set("набор фруктов 3", 1250, new List<SubProduct> { product[0], product[1], product[4]});

        foreach (var item in set)
        {
            item.PrintInfo();   
            item.FindExpirationDate();
        }

        Batch[] batch = new Batch[2];

        batch[0] = new Batch("партия 1 ", 300, 2, new DateTime(2023, 12, 3, 18, 30, 12), new DateTime(2024, 03, 4, 18, 30, 12));
        batch[1] = new Batch("партия 2 ", 600, 2, new DateTime(2023, 12, 3, 18, 30, 12), new DateTime(2023, 03, 4, 18, 30, 12));

        foreach (var item in batch)
        {
            item.PrintInfo();
            item.FindExpirationDate();
        }



    }
}