using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Transport.Models
{
    internal class Bus : PetrolTransport
    {
        string subsubtype;
        public Bus(string destination, int number, DateTime departureTime, int countPlaces) : base(destination, number, departureTime, countPlaces)
        {
            subsubtype = "Bus";
        }

        public override void PrintType()
        {
            base.PrintType();
            Console.WriteLine($"SubSubType: {subsubtype}");
        }
    }
}
