using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Task1
    {
        public static bool Handler_Login(string login, string password, string confirmPassword)
        {
            bool flag = true;
            Regex regex = new Regex("[0-9]");

            try
            {
                if (login.Length >= 20)
                {
                    flag = false;
                    throw new WrongLoginException(login, "Логин содержит больше 20 символов");
                }
                else if (login.Contains(" "))
                {
                    flag = false;
                    throw new WrongLoginException(login, "Логин содержит пробел");
                }
                else if (password.Length >= 20)
                {
                    flag = false;
                    throw new WrongPasswordException(password, "Пароль содержит больше 20 символов");
                }
                else if (password.Contains(" "))
                {
                    flag = false;
                    throw new WrongPasswordException(password, "Пароль содержит пробел");
                }
                else if (!regex.IsMatch(password))
                {
                    flag = false;
                    throw new WrongPasswordException(password, "Пароль должен содержать хотя бы 1 цифру");
                }
                else if (!password.Equals(confirmPassword))
                {
                    flag = false;
                    throw new WrongPasswordException(password, confirmPassword, "Не совпадают значения");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            return flag;
        }
    }
}
