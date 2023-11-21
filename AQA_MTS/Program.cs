using System;

namespace AQA_MTS
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задание 1
                 Создайте массив целых чисел. 
                 Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.
                 Пусть число для поиска задается с консоли.*/

            /* int[] array = new int[20];

             for (int i = 0; i < array.Length; i++)
             {
                 array[i] = new Random().Next(100);
                 Console.Write($"{array[i]}  ");
             }
             Console.Write("\n Введите число : ");
             int number = Convert.ToInt32(Console.ReadLine());
             bool flag = false;

             for (int i = 0; i < array.Length; i++)
             {
                 if (array[i] == number) flag = true;
             }

             Console.WriteLine($"Входит ли {number} в массив ?  : {flag}");*/

            /*
                        Задание 2
                        Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
                        Пусть число задается с консоли.Если такого числа нет -выведите сообщения об этом.
                        В результате должен быть новый массив без указанного числа.*/

            /* Console.Write("Введите размерность массива : ");
             int n = Convert.ToInt32(Console.ReadLine());

             int[] array1 = new int[n];
             int[] array1_copy = new int[n-1];

              for (int i = 0; i < n; i++)
             {
                 array1[i] = new Random().Next(100);
                 Console.Write($"{array1[i]}  ");
             }

             Console.Write("\n Введите число : ");
             int number1 = Convert.ToInt32(Console.ReadLine());

             bool flag1 = false;
             int j=0,k=0;

             for (int i = 0; i < n; i++)
             {
                 if (array1[i] == number1)
                 {
                     flag1 = true;
                     j=i;
                 }

             }

             if (flag1 == true)
             {
                 for (int i = 0; i < n; i++)
                 {
                     if (i == j) continue;
                     array1_copy[k] = array1[i];
                     k++;
                 }

                 Console.WriteLine("Новый массив:");

                 for (int i = 0; i < array1.Length - 1; i++)
                 {

                     Console.Write($" {array1_copy[i]}  ");

                 }
             }
             else Console.Write($"Число {number1} не входит в массив");*/

            /* Задание 3
             Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
             Для генерации случайного числа используйте метод Random().
             Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.*/

            /*          Console.Write("Введите размерность массива : ");
                      int n = Convert.ToInt32(Console.ReadLine());

                      int[] array2 = new int[n];
                      int max = -9999, min = 9999, sum = 0;
                      for (int i = 0; i < n; i++)
                      {
                          array2[i] = new Random().Next(100);
                          Console.Write($"{array2[i]}  ");
                      }

                      for (int i = 0; i < n; i++)
                      {
                          if (array2[i] < min) min = array2[i];
                          if (array2[i] > max) max = array2[i];
                          sum += array2[i];
                      }

                      for (int i = 0; i < n; i++)
                      { 
                          int tmp = 0;

                          for (int j = 0; j < n - 1; j++)
                          {
                              if (array2[j] > array2[j + 1])
                              {
                                  tmp = array2[j];
                                  array2[j] = array2[j + 1];
                                  array2[j + 1] = tmp;
                              }

                          }

                      }

                      Console.WriteLine("\n Отсортированный массив:");

                      for (int i = 0; i < n; i++)
                      {
                          Console.Write($"{array2[i]}  ");

                      }

                      Console.WriteLine($" \n max = {max} \n min = {min} \n Sum/n = {sum / n}");

                      if (n % 2 == 1) 
                      { Console.WriteLine($"Mean = {array2[n / 2]}");
                      }
                      else { Console.WriteLine($"Mean = ({array2[n / 2-1]} +  {array2[5]})/ 2 = { Convert.ToDouble((array2[n / 2 - 1] + array2[n / 2 ])/2.0) }");
                          }*/

            /* Задание 4
             Создайте 2 массива из 5 чисел.
             Выведите массивы на консоль в двух отдельных строках.
             Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось
             больше(либо сообщите, что их средние арифметические равны).*/

            /* int[] array3 = new int[5];
             int[] array4 = new int[5];

             for (int i = 0; i < 5; i++)
             {
                 array3[i] = new Random().Next(10);
                 array4[i] = new Random().Next(10);

             }  
             Console.WriteLine("Массив 1 : ");

             for (int i = 0; i < 5; i++)
             {

                 Console.Write($"{array3[i]} ");

             }
             Console.WriteLine("");
             Console.WriteLine("Массив 2 : ");
             for (int i = 0; i < 5; i++)
             {

                 Console.Write($"{array4[i]} ");

             }
             int sum3 = 0, sum4 = 0;
             for(int i=0; i<5; i++)
             {
                 sum3 += array3[i];
                 sum4 += array4[i];

             }

             if (Convert.ToDouble(sum3 / 2.0) == Convert.ToDouble(sum4 / 2.0)) Console.WriteLine("Средние арифметические равны ");
             else if (Convert.ToDouble(sum3 / 2.0) > Convert.ToDouble(sum4 / 2.0)) Console.WriteLine("Для 1-го массива ср.а. больше ");
             else Console.WriteLine("Для 2-го массива ср.а. больше ");*/

            /*Задание 5
            Создайте массив из n случайных целых чисел и выведите его на экран.
            Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.
            Если n не удовлетворяет условию - выведите сообщение об этом.Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.
            Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.*/
            Console.WriteLine("Введите число");
            int n1 = Convert.ToInt32(Console.ReadLine());

            while( n1 > 10 || n1 <= 5 )
            {
                Console.WriteLine("Введенное число не принадлежит интервалу (5,10]. Введите новое число");
                n1 = Convert.ToInt32(Console.ReadLine());
            }

            int[] array5 = new int[n1];
            int[] array6 = new int[n1];
            int count = 0;

            for (int i = 0; i < n1; i++) array5[i] = new Random().Next(10);

            Console.WriteLine("");
            Console.WriteLine("Массив 1 : ");
            for (int i = 0; i < n1; i++)  Console.Write($"{array5[i]} ");
           
            for (int i = 0; i < n1; i++)
            {

                if (array5[i] % 2 == 0) { array6[count] = array5[i]; count++; }

            }
            Console.WriteLine("");
            Console.WriteLine("Массив 2 : ");
            for (int i = 0; i <count; i++)  Console.Write($"{array6[i]} ");
         
        }
    }
}
