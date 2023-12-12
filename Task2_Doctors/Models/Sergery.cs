using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Doctors.Models
{
    public class Sergery : Doctor
    {
        public Sergery(string fio) : base(fio)
        {
        }

        public override void Treat()
        {
            base.Treat();
            Console.WriteLine("Операция прошла успешно");
        }
    }
}
