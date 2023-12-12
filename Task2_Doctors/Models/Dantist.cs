using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Doctors.Models
{
    public class Dantist : Doctor
    {
        public Dantist(string fio) : base(fio)
        {
        }
        public override void Treat()
        {
            base.Treat();
            Console.WriteLine("Зубы вылечены успешно");
        }
    }
}
