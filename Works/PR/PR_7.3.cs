using System;

namespace _22_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Найти сумму всех элементов массива вещественных чисел, больших заданного
              числа (вводится с консоли). Размерность массива – 20 Заполнение массива
              осуществить случайными числами от 50 до 100*/

            int[] array = new int[20];
            int sum = 0;

            for(int i = 0; i < array.Length; i++)
            {
                Random random = new Random();
                int number = random.Next(50, 100);
                array[i] = number;

                Console.Write(array[i] + " ");


            }
            Console.WriteLine();
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(sum);
            
        }
    }
}
