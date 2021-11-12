using System;

namespace PR_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float number;
            int change;
            Console.Write("Введите число бит: ");
            number = float.Parse(Console.ReadLine());

            Console.WriteLine("Выбирите операцию: \n");
            Console.WriteLine("1.Перевод в байты\n2.Перевод в килобайты\n3.Перевод в мегабайты\n4.Перевод в гигабайты\n5.Перевод в терабайты");

            change = int.Parse(Console.ReadLine());

            switch (change) {
                case 1:
                    Console.WriteLine(number / 8 + " байт");
                    break;
                case 2:
                    Console.WriteLine(number / 8 / 1024 + " Кбайт");
                    break;
                case 3:
                    Console.WriteLine(number / 8 / 1024 / 1024 + " Мбайт");
                    break;
                case 4:
                    Console.WriteLine(number / 8 / 1024 / 1024 / 1024 + " Гбайт");
                    break;
                case 5:
                    Console.WriteLine(number / 8 / 1024 / 1024 / 1024 / 1024 + "Тбайт");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                break;
            }
            
        }
    }
}
