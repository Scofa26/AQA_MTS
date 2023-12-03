using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Task4
{
    public class Plan
    {
        int num; //номер плана лечения
        public Plan(int num)
        {
            this.num = num;
        }

        public int Num { get => num; set => num = value; }
    }
}
