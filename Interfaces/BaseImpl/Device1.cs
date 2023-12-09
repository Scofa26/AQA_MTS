namespace Interfaces.BaseImpl;

public class Device1 : Example.IDisplayable
{
    public virtual void DisplayInformation(string information)
    {
        Console.WriteLine($"Device1 Display: {information}");
    }
}