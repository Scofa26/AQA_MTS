 class Program
{
    internal delegate void Handler(string alpha, string beta);
    public static event Handler OnStuck; 
     static void Main()
    {
        OnStuck += ShowMessage;
        OnStuck("Alex", "uui");
    }

    private static void ShowMessage(string firstname, string secondname)
    {
        Console.WriteLine($"{firstname}{secondname} Have fun")
    }
}