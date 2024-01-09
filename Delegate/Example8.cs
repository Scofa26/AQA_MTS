using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Example8
    {
        delegate T Operation<T, K>(K variable);
        public void Run() {
            Operation<decimal, int> squareOperation = Square;
            decimal resulr = squareOperation(5);
            Console.WriteLine(resulr);

            Operation<int, int> DoubleOperation = Double;
            int result = DoubleOperation(5);
            Console.WriteLine(result);

        }

        private decimal Square(int n) => n * n;
        int Double(int n) => n+n;
    }
}
