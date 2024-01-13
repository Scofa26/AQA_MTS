internal class Program
{
    private static void Main(string[] args)
    {
        List<int> ints = [1, 2, 3, 4, 5];
        HashSet<int> myhash1 = new HashSet<int>();
        foreach (int i in ints) 
            myhash1.Add(i);

        foreach (int i in myhash1)
            Console.WriteLine(i);
    }
}