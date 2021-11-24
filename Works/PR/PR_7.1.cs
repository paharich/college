using System;

namespace _22_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создайте массив из любых целых чисел, обязательно чтобы там были и
            положительные и отрицательные значения. Найдите минимальный элемент в
            массиве.Замените все элементы массива на минимальный элемент.
            Пример массива: [-1, 1, 2, 3]. Результат:[-1, -1, -1, -1];*/

            int[] array = {-1,2,-5,10 };
            int min = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];
                }

                array[i] = min;
            }

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = min;
                Console.Write(array[i] + "\t");
            }
            
            
        }
    }
}
