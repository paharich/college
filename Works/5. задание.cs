using System;

namespace _22_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
		int A = int.Parse(Console.ReadLine());
            	int B = int.Parse(Console.ReadLine());
            	int C = int.Parse(Console.ReadLine());

            	int[] array = { A, B, C };
            	int max = 0, min = int.MaxValue;

            	for (int i = 0; i < array.Length; i++)
            	{

                	if (array[i] < min)
                	{
                    	min = array[i];
                	}
                	if (array[i] > max)
                	{
                    	max = array[i];
                	}

            	}

            	int Result = max - min;

            	Console.WriteLine(Result);


        }
    }
}
