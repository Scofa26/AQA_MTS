using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Delegate
{
    internal class Task1
    {
        public delegate int ReturnInt();

        public void Run()
        {
            ReturnInt returnint = PrintInt;
            returnint.Invoke();
        }

        public int PrintInt()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 10);
            Console.WriteLine(n);
            return n;
        }
    }
}
