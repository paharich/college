using System;

namespace DZ_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("X    |   Y");    //Под ними будут писаться X и Y для удобства понимания выведенных чисел
            Console.WriteLine();    //Пропуск между строками

            for (int x = 10; x >= 10 && x <= 100; x++)   //Цикл со значением Х от 10 до 100 включительно
            {
                float y = 123.78f * (99.743f* x * (x - 0.57f)); // Вычисление "Y" по формуле
                Console.Write(x);   //Вывод икса в консоль
                Console.Write("   |   ");   //Вывод знака разделения между X и Y
                Console.WriteLine(y);   //Вывод игрика в консоль
                Console.WriteLine();    //Пропуск между строками
            }
        }
    }
}
