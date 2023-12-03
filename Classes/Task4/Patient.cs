using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Classes.Task4
{
    public class Patient
    {
        string name;
        public void Assign(int plan)
        {
            switch (plan)
            {
                case 1:
                    Doctor sergery = new Doctor("Склифосовский И.И.");
                    Console.WriteLine(sergery.FIO);
                    sergery.treatSurgery();
                    break;
                case 2:
                    Doctor dantist = new Doctor("Пирогов В.А.");
                    Console.WriteLine(dantist.FIO);
                    dantist.treatTherapist();
                    break;
                case 3:
                    Doctor therapist = new Doctor("Вишняков Ф.А.");
                    Console.WriteLine(therapist.FIO);
                    therapist.treatDantist();
                    break;

            }
        }
    }
}
