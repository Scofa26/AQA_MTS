using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Doctors.Models
{
    public class Therapist : Doctor
    {
        public Therapist(string fio) : base(fio)
        {
        }
        public override void Treat()
        {
            base.Treat();
            Console.WriteLine("Диагноз назначен успешно");
        }
    }
}
