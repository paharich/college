using System;

namespace PR_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите число от 0 до 9");

            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Первый");
                    break;
                case 2:
                    Console.WriteLine("Второй");
                    break;
                case 3:
                    Console.WriteLine("Третий");
                    break;
                case 4:
                    Console.WriteLine("Четвёртый");
                    break;
                case 5:
                    Console.WriteLine("Пятый");
                    break;
                case 6:
                    Console.WriteLine("Шестой");
                    break;
                case 7:
                    Console.WriteLine("Седьмой");
                    break;
                case 8:
                    Console.WriteLine("Восьмой");
                    break;
                case 9:
                    Console.WriteLine("Девятый");
                    break;
                default:
                    Console.WriteLine("Число не в ходит этот диапозон");
                    break;
            }

        }
    }
}
