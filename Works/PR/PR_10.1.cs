using System;


namespace _22_11_2021
{
    class Program
    {
        static double D = 0, X1 = 0, X2 = 0, X1_1 = 0, X2_2 = 0;
        static void Main(string[] args)
        {
            /*Напишите программу решения биквадратного уравнения «Ax2+Bx+C=0»,
            используя подпрограмму решения квадратного уравнения, которая будет
            возвращать результат в глобальные переменные. Значения переменных A, B, C
            вводятся с консоли. Вывести ответ на экран.*/

            Console.WriteLine("Как выглядит конструкция уравнения?");
            Console.WriteLine("1.   Ax2+Bx+C=0\n");
            Console.WriteLine("2.   Ax4+Bx2+C=0\n");
            Console.Write("Введите число: ");
            int k = int.Parse(Console.ReadLine());

            switch (k)
            {
                case 1:
                    FormulaD();
                    break;

                case 2: FormulaD_2();
                    break;

                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }

        }

        //***Если выбрать 1***
        public static void FormulaD()
        {
            double A, C, B;

            Console.Write("Введите A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
            C = double.Parse(Console.ReadLine());

            D = Math.Pow(B, 2) - (4 * A * C);  //Math.Pow - возведение в степень (Что, на какую степень или целочисленную переменную)
            if (D > 0)
            {
                X1 = (-B + Math.Sqrt(D)) / (2 * A); //Math.Sqrt(переменная) возведение в корень
                X2 = (-B - Math.Sqrt(D)) / (2 * A); //Math.Sqrt(переменная) возведение в корень
                Console.WriteLine("Х1 = " + X1);
                Console.WriteLine("Х2 = " + X2);
            }
            else if (D == 0)
            {
                X1 = (-B) / (2 * A);
                Console.WriteLine("Х1 = " + X1);
                Console.WriteLine("Х2 в данном решение нет");
            }
            else
            {
                Console.WriteLine("Решения нет!");
            }



        }

        //***Если выбрать 2***
        public static void FormulaD_2()
        {
            double A, C, B;

            Console.Write("Введите A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
            C = double.Parse(Console.ReadLine());

            D = Math.Pow(B, 2) - (4 * A * C);  //Math.Pow - возведение в степень (Что, на какую степень или целочисленную переменную)
            if (D > 0)
            {
                X1 = (-B + Math.Sqrt(D)) / (2 * A); //Math.Sqrt(переменная) возведение в корень
                X2 = (-B - Math.Sqrt(D)) / (2 * A); //Math.Sqrt(переменная) возведение в корень
                X1_1 = Math.Sqrt(X1);
                X1 = Math.Sqrt(X1);
                X2_2 = Math.Sqrt(X2);
                X2 = Math.Sqrt(X2);



                Console.WriteLine("Х1 = " + X1);
                Console.WriteLine("Х2 = " + "-" + X1_1);
                Console.WriteLine("Х3 = " + X2);
                Console.WriteLine("Х4 = " + "-" + X2_2);
            }
            else if (D == 0)
            {
                X1 = (-B) / (2 * A);
                X1_1 = Math.Sqrt(X1);
                X1 = Math.Sqrt(X1);
                Console.WriteLine("Х1 = " + X1);
                Console.WriteLine("Х2 = " + "-" + X1_1);
                Console.WriteLine("Х3 в данном решение нет");
                Console.WriteLine("Х4 в данном решение нет");
            }
            else
            {
                Console.WriteLine("Решения нет!");
            }
            Console.WriteLine("Если пишет 'не число' - это означает, что нарушено правило Х^2 >= 0, так же это равносильно отсутствию решения");

        }
    }
}
