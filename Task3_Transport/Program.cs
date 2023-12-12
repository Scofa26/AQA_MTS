using System.Collections.Immutable;
using Task3_Transport.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Transport[] transport = new Transport[6];

        transport[0] = new Bus("Краснодар", 111, new DateTime(2023, 12, 3, 18, 30, 12), 23);
        transport[1] = new Bus("Москва", 222, new DateTime(2023, 12, 4, 14, 20, 10), 33);
        transport[2] = new Train("Рязань", 333, new DateTime(2023, 12, 5, 15, 20, 10), 144);
        transport[3] = new Train("Хабаровск", 444, new DateTime(2023, 12, 6, 10, 40, 10), 200);
        transport[4] = new TrolleyBus("Ул.Мира", 13, new DateTime(2023, 12, 7, 09, 51, 10), 46);
        transport[5] = new TrolleyBus("Ул.Селезнева", 27, new DateTime(2023, 12, 8, 19, 51, 10), 40);

        TransportService.PrinttransortType(transport[0]);
        transport[0].PrintScheduleNotVirtualMethod();

        TransportService.PrinttransortType(transport[1]);
        transport[1].PrintScheduleNotVirtualMethod();

        TransportService.PrinttransortType(transport[2]);
        transport[2].PrintScheduleNotVirtualMethod();

        TransportService.PrinttransortType(transport[3]);
        transport[3].PrintScheduleNotVirtualMethod();

        TransportService.PrinttransortType(transport[4]);
        transport[4].PrintScheduleNotVirtualMethod();

        TransportService.PrinttransortType(transport[5]);
        transport[5].PrintScheduleNotVirtualMethod();

        Array.Sort(transport, (x, y) => x.CountPlaces.CompareTo(y.CountPlaces));
        for (int i = 0; i < transport.Length; i++)
            Console.WriteLine($"{i} : {transport[i].Number}, {transport[i].Destination}, {transport[i].DepartureTime}, {transport[i].CountPlaces} ");

        Console.WriteLine("Введите дату в формате dd.MM.YYYY HH:MM:SS ");
        DateTime userDateTime;
        if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
        {
            Console.WriteLine("Вы ввели:" + userDateTime);
        }
        else
        {
            Console.WriteLine("Дата некорректна");
        }
        Console.ReadLine();

        //н-р, 03.12.2023 18:30:12 
        foreach (var tran in transport)
            if (tran.DepartureTime == userDateTime)
                Console.WriteLine($"Подходящий транспорт по времени : {tran.Number}, {tran.Destination}, {tran.CountPlaces}, {tran.DepartureTime}");
            else
            {
                Console.WriteLine("Подходящий транспорт не найден");
                break;
            }
    }
}