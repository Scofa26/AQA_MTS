using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Doctors.Models
{
    public class Doctor : Person
    {
        public Doctor(string fio) : base(fio)
        {
        }

        public virtual void Treat() 
        {
            Console.WriteLine("Вы здоровы.");
        }
    }
}
