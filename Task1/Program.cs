using System.Drawing;
using Task1.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        double S = 0;
        Figure[] figures = new Figure[5];
        figures[0] = new Task1.Models.Rectangle(1, 2);
        figures[1] = new Task1.Models.Rectangle(4, 3);
        figures[2] = new Task1.Models.Rectangle(5, 8);
        figures[3] = new Circle(3);
        figures[4] = new Triangle(5, 5, 5);

        foreach (var figure in figures)
        {
            figure.Square();
            figure.Perimeter();
            figure.PrintInfo();
            S += figure.Sum();
        }

        Console.WriteLine($"Сумма = {S}");
    }
}