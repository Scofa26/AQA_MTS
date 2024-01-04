using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Example4
    {
        // Тип делегата
        public delegate void NoParameters();
        delegate int Operation(int x, int y);
        public void Run()
        {
            NoParameters noPrm = delegate
            {
                Console.WriteLine("Have fun!");
            };

            noPrm();
            // Делегаты как параметры методов 
            Console.WriteLine(Test(noPrm));

            //Ыозвращение делегатов из метода 
            Operation operation = SelectOperation(OperationType.Add);
            Console.Write(operation(10,4));

             operation = SelectOperation(OperationType.Subtract);
            Console.Write(operation(10, 4));

             operation = SelectOperation(OperationType.Multiply);
            Console.Write(operation(10, 4));

        }
        private bool Test(NoParameters delagateValue)
        {
            delagateValue();
            return true;

        }

        private int Add(int x, int y) => x + y;
        private int Subtrack(int x, int y) => x - y;
        private int Multiply(int x, int y) => x * y;

        private Operation SelectOperation(OperationType operationtype)
        {
            switch (operationtype)
            {
                case OperationType.Add: return new Operation(Showdata)+Add;
                
                case OperationType.Subtract: return Subtrack;
                default: return Multiply;

            }
        }
        private int Showdata (int x, int y )
        {
            Console.WriteLine($"Начало операции {x} {y}");
            return 0;
        }
    }
}
