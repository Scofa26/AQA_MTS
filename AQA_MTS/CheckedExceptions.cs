using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CheckedExceptions
    {
        public void ReadFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }

        public void correctReadFile(string filePath)
        {
            try
            {
                ReadFile(filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
            }
        }
    }
}
