using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException()
        {
        }

        public WrongLoginException(string login, string message) : base($"Неверный ввод в поле '{login}': {message}")
        {
        }
    }
}
