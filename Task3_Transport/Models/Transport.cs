using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Transport.Models
{
    internal class Transport
    {
        string type;
        string destination;
        int number;
        DateTime departureTime = new DateTime();
        int countPlaces;
        public Transport(string destination, int number, DateTime departureTime, int countPlaces)
        {
            type = "Public";
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
            this.countPlaces = countPlaces;
        }

        public string Type { get => type; set => type = value; }
        public string Destination { get => destination; set => destination = value; }
        public int Number { get => number; set => number = value; }
        public DateTime DepartureTime { get => departureTime; set => departureTime = value; }
        public int CountPlaces { get => countPlaces; set => countPlaces = value; }

        public virtual void PrintType()
        {
            Console.WriteLine($"Type : {type}");
        }

        public  void PrintScheduleNotVirtualMethod()
        {
            Console.WriteLine($"Направление: {destination}, номер {number}, дата отправления {departureTime}, кол-во мест {countPlaces}") ;
        }
    }
}
