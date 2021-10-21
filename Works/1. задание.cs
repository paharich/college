using System;

namespace DZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа.");
            int a, b, c;
            Console.Write("Введите число A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                ;   //Не трогать! Так надо
            }
            else if (a > b && a > c)
            {
                a *= a;
                Console.Write("Число А наибольшее. A^2 = ");
                Console.WriteLine(a);
            }

            if (b < a && b < c)
            {
                ;   //Не трогать! Так надо
            }
            else if (b > a && b > c)
            {
                b *= b;
                Console.Write("Число B наибольшее. B^2 = ");
                Console.WriteLine(b);
            }

            if (c < b && c < a)
            {
                ;   //Не трогать! Так надо
            }
            else if (c > b && c > a)
            {
                c *= c;
                Console.Write("Число C наибольшее. C^2 = ");
                Console.WriteLine(c);
            }

        }
    }
}
