using System;

namespace PR_8
{
	class Program
	{
		public static void Main(string[] args)
		{
//			Дан целочисленный массив В[1..4, 1..3]. Заменить все его элементы их квадратами.
			
			int[,] array = new int[3,3]{ {1,3,5}, {2,4,6}, {5,10,15} };
			
			
			for (int i = 0; i < array.GetLength(0); i++) {
				Console.WriteLine();
				for (int j = 0; j < array.GetLength(1); j++) {
					//array[i, j] *= ++i;
					//array[i, j] *= ++j;
					array[i ,j] *= array[i ,j];
					Console.Write('\t');
					Console.Write(array[i, j]);
				}				
				
			}
			
			
			Console.ReadKey(true);
		}
	}
}