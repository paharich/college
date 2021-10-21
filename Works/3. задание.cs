using System;

namespace DZ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Шишка -> Пышка
            Console.WriteLine("ИЗ ШИШКИ В ПЫШКУ");  //вывод надписи
            String word = "Шишка";  //Присвоение значения переменной строкового типа 
            Console.WriteLine("Было: " + word); //Вывод изначального значения, хранящегося в переменной
            word = String.Concat((char)(word[0] - 9), (char)(word[1] + 19), word.Substring(2)); //Изменение содержания переменной, замена первого и второго символа и продолжение с 3-го символа
            Console.WriteLine("Стало: " + word + "\n\n");    //Вывод изменённого значения переменной word
            

            //Определения количества слов
            Console.WriteLine("ОПРЕДЕЛЕНИЕ КОЛИЧЕСТВА СЛОВ");
            Console.WriteLine("Введите текст: ");
            String text;
            text = Console.ReadLine();
            int i = 0;

            for(int counter = 0; counter < text.Length; counter++) {
                if(text[counter] == ' ') {
                    i += 1;
                }
            }
            i = i + 1;
            Console.WriteLine("Количество слов в предложение" + " '" + text + "' " + "составляете " + i + "\n\n");
            
            
            //Три фамилии
            Console.WriteLine("КАКАЯ ФАМИЛИЯ БОЛЬШЕ?\n");
            Console.Write("Первая фамилия: ");
            string SecondName_1 = Console.ReadLine();
            Console.Write("Вторая фамилия: ");
            string SecondName_2 = Console.ReadLine();
            Console.Write("Третья фамилия: ");
            string SecondName_3 = Console.ReadLine();
            if (SecondName_1.Length > SecondName_2.Length) {
                Console.WriteLine("Фамилия " + SecondName_1 + " длиннее остальных");
            } else if(SecondName_2.Length > SecondName_3.Length) {
                Console.WriteLine("Фамилия " + SecondName_2 + " длиннее остальных");
            }else Console.WriteLine("Фамилия " + SecondName_3 + " длиннее остальных" );
            
        }
    }
}
