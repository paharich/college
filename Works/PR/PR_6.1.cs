using System;
using System.Globalization;

namespace PR_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите предложение");  //вывод надписи
            string word = Console.ReadLine();  //Присвоение значения
            Console.WriteLine("Было: " + word); //Вывод изначального значения
            TextInfo s = CultureInfo.CurrentCulture.TextInfo;
            //word.Substring(0);
            Console.WriteLine("Стало: " + s.ToTitleCase(word) + "\n\n") ;    

        }

    }
}
