using Delegates;
using Delegates.Task3;
using System.Security.Cryptography.X509Certificates;
using Task1_Delegate;

internal class Program
{
    private static void Main(string[] args)
    {
        
        new Task1().Run();
        new Task2().Run(3);

        //Task3
        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(100);

        Console.WriteLine("Исходный массив");
        PrintHelper.Print(array);

        new Task3().Run(array, SortTypes.BubbleSort);
        Console.WriteLine("После сортировки пузырьком");
        PrintHelper.Print(array);

        new Task3().Run(array, SortTypes.ShakerSort);
        Console.WriteLine("После шейкерной сортировки");
        PrintHelper.Print(array);

    }
}