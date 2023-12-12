using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Doctors.Models
{
    public class Patient : Doctor
    {
        public Patient(string fio) : base(fio)
        {
        }

        public void Assign(int plan)
        {
            switch (plan)
            {
                case 1:
                    Sergery sergery = new Sergery("Склифосовский И.И.");
                    sergery.PrintInfo();
                    sergery.Treat();
                    break;
                case 2:
                    Dantist dantist = new Dantist("Пирогов В.А.");
                    dantist.PrintInfo();
                    dantist.Treat();
                    break;
                case 3:
                    Therapist therapist = new Therapist("Вишняков Ф.А.");
                    therapist.PrintInfo();
                    therapist.Treat();
                    break;

            }
        }
    }
}
