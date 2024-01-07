using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class WrongPasswordException : Exception
    {
        public WrongPasswordException()
        {
        }

        public WrongPasswordException(string password, string message) : base($"Неверный ввод в поле '{password}': {message}")
        {
        }
        public WrongPasswordException(string password, string confirmPassword, string message)
            : base($"Неверный ввод в полях '{password}' и '{confirmPassword}': {message}")
        {
        }
    }
}
