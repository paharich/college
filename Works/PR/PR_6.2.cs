using System;

namespace PR_6
{
    class Program
    {
        static void Main(string[] args)
        {
	//УЧЕБНИК->ЗАДАЧНИК
            String word = "УЧЕБНИК";  //Присвоение значения переменной строкового типа 
            Console.WriteLine("Было: " + word); //Вывод изначального значения, хранящегося в переменной
            word = String.Concat((char)(word[0] - 12), (char)(word[1] - 23), (char)(word[2] - 1), (char)(word[3] - 1), (char)(word[4] + 10), (char)(word[5] + 5), (char)(word[6] - 2), word.Substring(6)); //Изменение содержания переменной, замена первого и второго символа и продолжение с 3-го символа
            Console.WriteLine("Стало: " + word + "\n\n");    //Вывод изменённого значения переменной word
        }
    }
}