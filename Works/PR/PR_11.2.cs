using System;

namespace PR_11
{
	class Program
	{
		struct TeachedChild
		{
			public string firstName;
			public string secondName;
			public int rating;
		}


		public static void Main(string[] args)
		{
			/*Напишите программу, которая собирает данные о N-учениках: ФИО, оценка за год.
    		Данные вводятся с консоли. Выведите данные о всех хорошистах и отличниках.*/

			TeachedChild[] child = new TeachedChild[5];

			Console.WriteLine("Чтобы начать нажмите Enter");
			while (Console.ReadLine() != "q")
			{
				Console.WriteLine("Заполнение.\n");
				for (int i = 0; i < child.Length; i++)
				{
					Console.Write("Фамилия: ");
					child[i].firstName = Console.ReadLine();
					Console.Write("Имя: ");
					child[i].secondName = Console.ReadLine();
					Console.Write("Оценка: ");
					child[i].rating = int.Parse(Console.ReadLine());
				}
				Console.WriteLine("Если хотите выйти нажмите q.");
			}
			Console.WriteLine("Вы вышли.");

			Console.Write("Вывести хорошистов и отличников(напиши 4 или 5): ");

			int num = int.Parse(Console.ReadLine());
			int StrNum = num;

			for (int i = 0; i < child.Length; i++)
			{
				if (child[i].rating == 4 || child[i].rating == 5)
				{
					Console.WriteLine("Оценка: " + child[i].rating + '\t' +
										  "Фамилия: " + child[i].firstName + '\t' +
										"Имя: " + child[i].secondName + '\n');
				}
			}

			Console.ReadKey();

		}
	}
}