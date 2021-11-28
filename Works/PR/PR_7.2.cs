using System;

namespace ПР_7._
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] array = new int[12];
			for(int i = 0; i < array.Length; i++){
				array[i] = int.Parse(Console.ReadLine());
			}
			for(int i = 0; i < array.Length-1; i++){
				if(array[i+1] > array[i]){
					Console.Write( array[i]);
				}else Console.WriteLine(array[i]);
			}
			
			Console.ReadKey(true);
		}
	}
}