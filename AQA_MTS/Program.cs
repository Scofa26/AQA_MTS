using System;

namespace AQA_MTS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello user, {name}");
           */

            bool isWhiteBreadFreash = true;
            ushort whiteBreadPrice = 150;
            ushort butterPrice = 230;
            ushort milkPrice = 170;
            float milkFat = 1.2F;
            ushort icecreamPrice = 350;

            Console.Write("Введите начальную умму : ");
            string? sumstring = Console.ReadLine();
            short sum = Convert.ToInt16(sumstring);

            if (sum > 0)
            {
               /* if (isWhiteBreadFreash)
                {
                    sum = Convert.ToInt16(sum - whiteBreadPrice);

                }
                else
                {
                    Console.WriteLine("Батон несвежий");
                }*/

                if(!isWhiteBreadFreash)
                {
                    Console.WriteLine("Батон несвежий");

                }
                else if(sum>= whiteBreadPrice)
                {
                    sum = Convert.ToInt16(sum - whiteBreadPrice);
                    Console.WriteLine($"купили батон по цене {sum}");

                }
                else
                {
                    Console.WriteLine("На Батон нет денег");
                }

                sum = Convert.ToInt16(sum - butterPrice);

                if (milkFat == 1.2F)
                {
                    sum = Convert.ToInt16(sum - milkPrice);
                }

                    if (sum >= 350)
                {
                    sum = Convert.ToInt16(sum - icecreamPrice);

                }
                Console.Write($"Остаток: {sum}");
            }
            else
            {
                Console.Write("Сумма недостаточная для покупки");

            }

        }
    }
}
