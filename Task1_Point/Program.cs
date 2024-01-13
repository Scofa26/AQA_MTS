using Task1_Point;

internal class Program
{
    private static void Main(string[] args)
    {
        Point<int> pointInt = new Point<int>(1,2);
        pointInt.Print();

        Point<double> pointDouble = new Point<double>(3.1232, 2.3);
        pointDouble.Print();
    }
}