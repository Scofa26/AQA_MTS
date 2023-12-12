using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Transport.Models
{
    internal class ElectricTransport : Transport
    {
        string subtype;
        public ElectricTransport(string destination, int number, DateTime departureTime, int countPlaces) : base(destination, number, departureTime, countPlaces)
        {
            subtype = "Electric";
        }

        public override void PrintType()
        {
            base.PrintType();
            Console.WriteLine($"SubType: {subtype}");
        }
    }
}
