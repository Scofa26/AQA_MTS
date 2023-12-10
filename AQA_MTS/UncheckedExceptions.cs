using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class UncheckedExceptions
    {
        // Пример неконтролируемого исключения
        public void DivideNumbers(int a, int b)
        {
            int result = a / b; // Возможно возникновение ArithmeticException
        }
    }
}

