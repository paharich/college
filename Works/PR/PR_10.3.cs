using System;


namespace _22_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу для вычисления Факториал, с помощью рекурсивного
            вызова подпрограммы*/

            Console.Write("Факториал какого числа вы хотите узнать: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = Factorial(n);
            Console.WriteLine(factorial);


        }

        public static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }

        

    }
}
