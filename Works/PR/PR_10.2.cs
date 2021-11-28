using System;


namespace _22_11_2021
{
    class Program
    {
        static int[] mas_1 = new int[10];
        static int[] mas_2 = new int[10];
        static void Main(string[] args)
        {
            /*Написать программу, в которой с помощью подпрограммы будет происходить
            объединение двух массивов разной размерности.Итоговый массив вывести
            на экран. Массивы заполнять через Random Пример: [1, 2, 3] + [4, 5, 6, 7, 8] = [1, 2, 3, 4, 5, 6, 7, 8]*/
            Console.WriteLine();
            Array1();
            Console.WriteLine();
            Array2();
            Console.WriteLine();
            plus();


        }
        static void Array1()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Random random = new Random();
                int number = random.Next(0, 10);
                array[i] = number;
                mas_1[i] = array[i];

                Console.Write(array[i] + " ");


            }
        }
        static void Array2()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Random random = new Random();
                int number = random.Next(0, 10);
                array[i] = number;
                mas_2[i] = array[i];

                Console.Write(array[i] + " ");


            }
        }
        static void plus()
        {
            int[] plus = new int[20];
            
            //нужно дописать сложение массивов
        }
    }
}
