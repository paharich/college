using System;


namespace PR_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит строку.Вывести количество слов, которые начинаются с
            //одной буквы.

            Console.WriteLine("Напишите предложение");
            string words = Console.ReadLine();
            words = words.ToLower();    //Исключит зависимость от регистра
            string[] delWords = words.Split(' ');
            
            int count = 0;

            for (int i = 0; i < delWords.Length; i++)
            {
                if (delWords[i] == "привет")
                {
                    count++;


                }
                else Console.WriteLine("Слово " + delWords[i] + " другое");

            }
            Console.WriteLine(count);

        }
        
    }
}
