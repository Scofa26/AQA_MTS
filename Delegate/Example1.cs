using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Example1
    {
        // Тип делегата
        public delegate void NoParameters();

        public void Run()
        {
            // Экземпляр делегата
            NoParameters noParameters1 = new NoParameters(ShowMessage);
            NoParameters noParameters2 = new(ShowMessage);
            NoParameters noParameters3 = ShowMessage;

            noParameters1();
            noParameters2();
            noParameters3();
        }

        private void ShowMessage()
        {
            Console.WriteLine("Have fun!!!");
        }
    }
}
