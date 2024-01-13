using Task2_Obj;

internal class Program
{
    private static void Main(string[] args)
    {
        Class1<int> item = new Class1<int>(10);

        Random random = new Random();

        for(int i = 0; i < item.Size; i++) item.Items[i] = i;

        item.Add(9);
        item.Add(10);
        item.Add(11);

        Console.WriteLine("Массив до удаления");
        item.Print(item.Items);   
        item.Remove(9);
        Console.WriteLine("Массив после удаления");

        item.Print(item.Items);
        item.Search(3);
       
        int size = item.GetLenght();
        Console.WriteLine($"Размер массива = {size}");

    }
}