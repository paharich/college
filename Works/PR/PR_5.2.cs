using System;

namespace PR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Угадай число от 0 до 100");
            int number = -1;


            Random random = new Random(); //Создание объекта для генерации чисел
            int x = random.Next(0, 100); //Получить случайное число в диапазоне от 0 до 10

            while(number != x) {

                number = int.Parse(Console.ReadLine());
                if(number > x) {
                    Console.WriteLine("Перебор");
                }else if(number < x) {
                    Console.WriteLine("Недобор");
                }else Console.WriteLine("УГАДАЛ!!!");
            }
        }
    }
}
