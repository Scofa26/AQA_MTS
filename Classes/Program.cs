using Classes.Models;
using Encapsulation;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] array = { 1, 8, 14, -4, 0, 7 };

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

             // -=================== Передача параметров ===================-
             // -=================== По значению

             void SimpleAdd(int x, int y)                //По умолчанию аргументы передаются по значению,
             {
                 int ans = x + y;
                 // Вызывающий код не увидит эти изменения, т.к. модифицируется копия исходных данных,
             }

             // -=================== По ссылке
             // -=================== Out
             // Значения выходных параметров должны быть установлены внутри вызываемого метода.
             static void OutAdd(int x, int y, out int ans)
             {
                 ans = x + y;
             }
             // Присваивать начальные значения локальным переменным, используемым как выходные параметры, не обязательно
             // при условии, что они впервые используются
             OutAdd(90, 90, out int ans); // - Первый вариант

             //int ans;
             //Add(90, 90, out ans); // - Второй вариант

             Console.WriteLine("OutAdd: 90 + 90 = {0}", ans);

             // -=================== Ref
             void ModifyValue(ref int value)
             {
                 value = value * 2;
             }

             int mainValue = 5; // Обязательо нужно инициализировать , иначе - ошибка 
             ModifyValue(ref mainValue);


             // -=================== Возврат нескольких значений. Кортеж Tulpe 
             (string, int) GetPersonInfo()
             {
                 return ("John", 25);
             }

             var person = GetPersonInfo();
             Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");

             // -=================== Сжатый метод
             int ShortAdd(int х, int у) => х + у;

             // -=================== Рекурсивная функция
             int Factorial(int n)
             {
                 if (n == 1) return 1;

                 return n * Factorial(n - 1);
             }

             int factorial4 = Factorial(4);  // 24
             int factorial5 = Factorial(5);  // 120
             int factorial6 = Factorial(6);  // 720

             Console.WriteLine($"Факториал числа 4 = {factorial4}");
             Console.WriteLine($"Факториал числа 5 = {factorial5}");
             Console.WriteLine($"Факториал числа 6 = {factorial6}");



             // - ===========================Классы========================-
             EmptyClass emptyClass = new EmptyClass("sd");
             emptyClass = new EmptyClass(112);

             Person person1 = new Person("",12);

             person1.Print();*/



            //-==================================Практика===========================-
            //-===========================Задача1-===============================-

            Student[] students = new Student[14];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                students[i].name = "Alex" + i;
                students[i].group = new Random().Next(2);
                students[i].diplomMark = new Random().Next(1, 11);

            }

            Console.WriteLine($"{students.Length}");

            foreach (var student in students)
            {
                Console.WriteLine($" name = {student.name} + group = {student.group} + diplomMark {student.diplomMark}");
                Console.WriteLine();
            }
            Console.WriteLine("Список отличников");

            //-=========================Задача 2 

            foreach (var student in students)
            {
                if (student.diplomMark > 8) student.Print();
            }

            //- =============Задача 3 
            Student[] students1 = new Student[14];
            for (int i = 0; i < students.Length; i++) students1[i] = new Student("Alex" + i);

            foreach (var student in students1) student.Print();

            //- =============Задача 4

            Cat cat = new Cat();
            cat.name = "Barsi";
            cat.age = 2;
            cat.maxFoodCont = 3;

            Console.WriteLine($"Наелся ? - {cat.Feed(2)}");
            Console.WriteLine($"Наелся ? - {cat.Feed(4)}");
            Console.WriteLine("Наелся ? -{0}", cat.Feed(4) ? "Да":"Нет" );

            State state = new State();
            //state.internalVar - Ошибка 
        }
    }

}