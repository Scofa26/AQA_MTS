using Task1_Figures.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Figure[] figures = new Figure[5];
        figures[0] = Creator.Create(5,5,5);
        figures[1] = Creator.Create(9, 12, 15);
        figures[2] = Creator.Create(2, 3, 4);
        figures[3] = new Rectangle(2, 4);
        figures[4] = new SquareF(3);
        
        foreach (var figure in figures)
            figure.Square();
    }
}