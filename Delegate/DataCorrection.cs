using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class DataCorrection
    {
        public void UpdateData(int price)
        {
            Console.WriteLine($"Data was updated according to price: {price}");
        }
    }
}
