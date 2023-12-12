using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Transport.Models
{
    internal class TransportService
    {
        public static void PrinttransortType(Transport transport)
        {
            switch (transport)
            {
                case Bus bus:
                   // Bus bus = new Bus();
                    bus.PrintType();
                    break;
                case Train train:
                   // Train train = new Train();
                    train.PrintType();
                    break;
                case TrolleyBus trolleyBus:
                    //TrolleyBus trolleyBus = new TrolleyBus();
                    trolleyBus.PrintType();
                    break;
            }
        }
    }
}
