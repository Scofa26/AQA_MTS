using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Doctors.Models
{
    public class TreatmentPlan
    {
        int num; //номер плана лечения
        public TreatmentPlan(int num)
        {
            this.num = num;
        }

        public int Num { get => num; set => num = value; }
    }
}
