using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Example3
    {
        // Тип делегата
        public delegate void NoParameters();

        public void Run()
        {
            NoParameters noPrm = ShowMessage1;

            noPrm += ShowMessage2;

            noPrm.Invoke(); // Более унифицированный вызов методов делегата
        }

        private void ShowMessage1() => Console.WriteLine("Have fun!");

        private void ShowMessage2() => Console.WriteLine("See you!");
    }
}
