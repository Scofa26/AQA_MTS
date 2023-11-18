using System;


namespace AQA_MTS
{
    class Program
    {
        static void Main(string[] args)
        {

            //ЗАДАНИЕ1

            double x, y, result;
            string operation;

            Console.Write("Введите певрое число: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выбирите операцию: + ;  -  ;  /   ;  *  ");
            operation = Console.ReadLine();

            Console.Write("Введите второе число: ");
            y = Convert.ToDouble(Console.ReadLine());

            if (operation.Equals("/") && y == 0)
            {
                Console.WriteLine("Делить на ноль нельзя");
                return;

            }
            else
            {
                result = DoOperation(x, y, operation);
                Console.WriteLine($"результат {result}");
            }

            double DoOperation(double x1, double y1, string oper1)
            {
                double result = oper1 switch
                {
                    "+" => x1 + y1,
                    "-" => x1 - y1,
                    "*" => x1 * y1,
                    "/" => x1 / y1,
                    _ => 0
                };
                return result;
            }



            //  ЗАДАНИЕ2

            Console.WriteLine("Введите число от -50 до 50 ");
            double? number = Convert.ToDouble(Console.ReadLine());

            if (number < -50 || number > 50)
            {
                Console.WriteLine($"Число {number} не принадлежит отрезку [-50, 50 ]");
            }
            else
            {// [-40, -10] ; [-9, 0 ]; [1 , 10] ; [11, 40]
                if (number >= -40 && number <= -10) Console.WriteLine($"Число {number} находится в отрезке [-40; -10]");
                else if (number >= -9 && number <= -0) Console.WriteLine($"Число {number} находится в отрезке [-9; -0]");
                else if (number >= 1 && number <= 10) Console.WriteLine($"Число {number} находится в отрезке [1; 10]");
                else if (number >= 11 && number <= 40) Console.WriteLine($"Число {number} находится в отрезке [11; 40]");
                else Console.WriteLine($"Число {number} не принадлежит ни одному из указанных отрезков");
            }

            // ЗАДАНИЕ 3 


            string[] words = { "shine", "bright", "like", "diamond", "find", "light", "beautiful", "sea", "I", "choose" };
            Console.WriteLine("Выедите слово : сиять, ярко, как, бриллиант, найди, свет , красивый, море, Я, выбирать");
            string word_r = Console.ReadLine();

            Console.Write($"{Translate(word_r)}");

            string Translate(string word)
            {

                string result = word switch
                {
                    "сиять" => words[0],
                    "ярко" => words[1],
                    "как" => words[2],
                    "бриллиант" => words[3],
                    "найди" => words[4],
                    "свет" => words[5],
                    "красивый" => words[6],
                    "море" => words[7],
                    "Я" => words[8],
                    "выбирать" => words[9],

                };
                return result;
            }

            // ЗАДАНИЕ 4 

            Console.Write("Введите число : ");
            int z = Convert.ToInt32(Console.ReadLine());

            // 4.1 
            if (z % 2 == 1) Console.WriteLine($"{z} нечетное"); else Console.WriteLine($"{z} четное");


            // 4.2 
            Console.WriteLine($"{z} нечетное? : {check(z % 2)}");

            bool check (int ost)
            {
                bool result = ost switch
                {
                    0 => false,
                    1 => true
                };
                return result;
            }

        }
    }
}
