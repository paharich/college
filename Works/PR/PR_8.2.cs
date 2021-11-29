using System;

namespace PR_8
{
	class Program
	{
		public static void Main(string[] args)
		{
			//			Составьте программу, упорядочивающую по убыванию элементы каждой строки матрицы размером m*n.

			int[,] array = new int[3, 3] { { 5, 10, 15 }, { 2, 4, 6 }, { 1, 3, 5 } };
			Console.Write("Было: ");

			for (int i = 0; i < array.GetLength(0); i++)
			{
				Console.WriteLine();
				for (int j = 0; j < array.GetLength(1); j++)
				{
					Console.Write('\t');
					Console.Write(array[i, j]);
				}

			}

			Console.WriteLine();
			Console.WriteLine("Стало: ");

			for (int i = 0; i < array.GetLength(0); i++)
			{
				Console.WriteLine();

				for (int j = 0; j < array.GetLength(1); j++)
				{
					for(int k = 0; k < array.GetLength(1) - j - 1; k++)
                    {
						int per = array[i, k];
						array[i, k] = array[i, k + 1];
						array[i, k + 1] = per;
                    }
					

					
					//Прототип
					//Console.Write('\t');
					//Console.Write(array[i, j]);
					/*for (int jb = i; jb >= 0 && array[i, jb] < per; jb++)
                    {

                        array[i, j] = array[i, jb];

                        per = array[i, j];

						array[i, jb] = per;



                    }*/



				}
				

			}
			for (int i = 0; i < array.GetLength(0); i++)
			{
				Console.Write("\t");
				for (int j = 0; j < array.GetLength(1); j++)
				{
					Console.Write(array[i, j] + "\t");
				}
				Console.WriteLine();
			}

			Console.ReadKey(true);
		}
	}
}

