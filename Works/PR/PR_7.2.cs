using System;

namespace _22_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Пользователь вводит N (вводится с консоли) целых чисел, которые программа
              должна заносить в массив. Вывести только те элементы, которые
              располагаются в виде возрастающей последовательности.
              Пример массива: [-1, 5, 6, 0, -3, 5, 8, 9]. Результат: «-1 5 6 \n -3 5 8 9»*/

            int[] array = new int[12];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < array.Length; i++)
            {               
                    if (array[i] >= array[i] && array[i] == 0)
                    {
                        Console.WriteLine();
                    }
                    else Console.Write(array[i]);
                
            }


        }
    }
}
