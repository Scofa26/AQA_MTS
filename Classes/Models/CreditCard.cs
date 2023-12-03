using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class CreditCard
    {
        string numberBill;
        double currentSum;

        public CreditCard(string numberBill, double currentSum)
        {
            this.numberBill = numberBill;
            this.currentSum = currentSum;
        }

        public void addCash(double sum)
        {
            if (sum > 0)
            {
                Console.WriteLine($"Баланс до пополнения ={currentSum}");
                currentSum += sum;
                Console.WriteLine($"Баланс после пополнения ={currentSum}");
            }
            else Console.WriteLine("Ошибка - Введена отрицательная сумма");
        }

        public void delCash(double sum)
        {
            if (sum > 0 && (currentSum - sum)>= 0.0)
            {
                Console.WriteLine($"Баланс до снятия ={currentSum}");
                currentSum -= sum;
                Console.WriteLine($"Баланс после снятия ={currentSum}");
            }
            else if (currentSum - sum < 0.0) Console.WriteLine($"Ошибка - {currentSum} < {sum}");

            else Console.WriteLine("Ошибка - Введена отрицательная сумма");
        }

        public void Print()
        {
            Console.WriteLine($"номер карты = {numberBill}");
            Console.WriteLine($"баланс счета = {currentSum}");

        }
    }
}
