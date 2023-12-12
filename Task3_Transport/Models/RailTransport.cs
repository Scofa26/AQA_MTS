using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Transport.Models
{
    internal class RailTransport : Transport
    {
        string subtype;
        public RailTransport(string destination, int number, DateTime departureTime, int countPlaces) : base(destination, number, departureTime, countPlaces    )
        {
            subtype = "Rail";
        }

        public override void PrintType()
        {
            base.PrintType();
            Console.WriteLine($"SubType: {subtype}");
        }
    }
}
