using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Transport.Models
{
    internal class PetrolTransport : Transport
    {
        string subtype;
        public PetrolTransport(string destination, int number, DateTime departureTime, int countPlaces) : base(destination, number, departureTime, countPlaces)               
        {
            subtype = "Petrol";
        }

        public override void PrintType()
        {
            base.PrintType();
            Console.WriteLine($"SubType: {subtype}");
        }
    }
}
