using Classes.Models;
using Classes.Task4;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //-==========Задача1===================-
            Phone phoneDefault = new Phone();
            Phone phone2Params = new Phone("8392", "S10");
            Phone phone3Params = new Phone("90032", "E22", 322);

            phoneDefault.receiveCall("Noname");
            phone2Params.receiveCall("Noname121");
            phone3Params.receiveCall("Maniac");

            Console.WriteLine(phoneDefault.getNumber);
            Console.WriteLine(phone2Params.getNumber);
            Console.WriteLine(phone3Params.getNumber);

            phoneDefault.sendMessage("num1", "num2");
            phone2Params.sendMessage("num1", "num2", "num3", "num4", "num5");

            //-==========Задача2===================-

            CreditCard card1 = new CreditCard("11111",100);
            CreditCard card2 = new CreditCard("22222",200);
            CreditCard card3 = new CreditCard("33333",300);

            card1.addCash(100);
            card2.addCash(100);
            card3.delCash(150);

            card1.Print();
            card2.Print();
            card3.Print();

            //-==========Задача3===================-

            CashMachine cm = new CashMachine(10,20,30);
            cm.addBanknote(10);
            cm.addBanknote(20,30);
            cm.WithdrawBanknote(100);
            cm.WithdrawBanknote(5,2,2);

            //-==========Задача4===================-
            Plan plan1 = new Plan(1);
            Plan plan2 = new Plan(2);
            Plan plan3 = new Plan(3);

            Patient pathient1 = new Patient();
            Patient pathient2 = new Patient();
            Patient pathient3= new Patient();

            pathient1.Assign(plan1.Num);
            pathient2.Assign(plan2.Num);
            pathient3.Assign(plan3.Num);


        }
    }

}