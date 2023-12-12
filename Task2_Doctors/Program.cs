using System.Numerics;
using Task2_Doctors.Models;

internal class Program
{
    public static void Main(string[] args)
    {
        TreatmentPlan plan1 = new TreatmentPlan(1);
        TreatmentPlan plan2 = new TreatmentPlan(2);
        TreatmentPlan plan3 = new TreatmentPlan(3);

        Patient pathient1 = new Patient("Пациент1");
        Patient pathient2 = new Patient("Пациент2");
        Patient pathient3 = new Patient("Пациент3");

        pathient1.Assign(plan1.Num);
        pathient2.Assign(plan2.Num);
        pathient3.Assign(plan3.Num);
    }
}