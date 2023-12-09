using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Example
{
    public class Tablet : IDisplayable
    {
        public int SerialNumber;

        public void DisplayInformation(string information)
        {
            Console.WriteLine($"Tablet {information}");
        }
        public void DrawBorders()
        {
            Console.WriteLine("Tablet: Рисуем границы");
        }
    }
}
