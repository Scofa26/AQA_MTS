using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Task4
{
    public class Doctor
    {
        string fio;

        public Doctor(string fio)
        {
            this.fio = fio;
        }
        public string FIO { get => fio; set => fio = value; }
        public void treatSurgery()
        {
            Console.WriteLine("Операция успешна!");
        }
        public void treatTherapist()
        {
            Console.WriteLine("Вы здоровы!");

        }
        public void treatDantist()
        {
            Console.WriteLine("Зуб здоров!");

        }

    }
}
