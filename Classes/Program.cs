namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 14, -4, 0, 7 };

            PrintArray();

            Console.WriteLine();

            Array.Reverse(array);
            {
                PrintArray();
            }
            Console.WriteLine();

            void PrintArray ()
            {
                foreach (var item in array)
                {
                    Console.Write($"{item}\t");
                }

            }

            // -=================== Метод без параметров ===================-
            void MethodWithoutParameters()
            {
                // Тело метода
            }


            // -=================== Метод без возвращаемого значения ===================-
            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            PrintMessage("text");

            // -=================== Метод c возвращаемым значением  ===================-
            string GetInfo ()
            {
                return "Test";
            }

            // -=================== Метод с переменным числом аргументов ===================-
            int CalculateSum(params int[] numbers)
            {
                int sum = 0;

                foreach (int num in numbers)
                {
                    sum += num;
                }
                return sum;
            }

            int sum1 = CalculateSum(1, 2, 3, 4, 5);
            int sum2 = CalculateSum(); // Пустой вызов

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);
        }
    }

}