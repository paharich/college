/*Создайте программу по работе со списком праздников (Минимум три праздника).
В программе создайте коллекцию (List<T>) структур праздников со следующими полями: дата (DateTime),
название праздника, является ли праздник христианским.
Выведите в консоли название праздников и даты, которые проходят с 30 августа по 30 мая и являются христианскими.
*/

/*
Пример по работе с типом данных DateTime:
DateTime date1 = DateTime.Parse(“01.01.2021”);
DateTime date2 = DateTime.Parse(“02.01.2021”);
bool x = date1 > date2; // false
*/

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace PR_11
{
	class Program
	{
		struct Happy
		{
			public string prazdnik;
			public DateTime date;
			public string type;
		}


		public static void Main(string[] args)
		{

			List<Happy> day = new List<Happy>();
			Happy HDay = new Happy();

			HDay.prazdnik = "Рождество";
			HDay.date = DateTime.Parse("07.01.2021");
			HDay.type = "Православный";
			day.Add(HDay);

			HDay.prazdnik = "Старый Новый год в России";
			HDay.date = DateTime.Parse("14.01.2021");
			HDay.type = "Государственный";
			day.Add(HDay);

			HDay.prazdnik = "День защитника Отечества в России";
			HDay.date = DateTime.Parse("28.02.2021");
			HDay.type = "Государственный";
			day.Add(HDay);
			
			HDay.prazdnik = "День Победы 1941-1945";
			HDay.date = DateTime.Parse("09.05.2021");
			HDay.type = "Государственный";
			day.Add(HDay);

			HDay.prazdnik = "Суббота Троицкая";
			HDay.date = DateTime.Parse("07.06.2021");
			HDay.type = "Православный";
			day.Add(HDay);

			HDay.prazdnik = "Преображение Господе";
			HDay.date = DateTime.Parse("19.08.2021");
			HDay.type = "Православный";
			day.Add(HDay);

			HDay.prazdnik = "Рождество Пресвятой Богородицы";
			HDay.date = DateTime.Parse("21.09.2021");
			HDay.type = "Православный";
			day.Add(HDay);

			HDay.prazdnik = "Покров Пресвятой Богородицы";
			HDay.date = DateTime.Parse("14.10.2021");
			HDay.type = "Православный";
			day.Add(HDay);

			IEnumerable<Happy> happies =
				from s in day
				where s.date > DateTime.Parse("30.04.2021") && s.date < DateTime.Parse("30.08.2021") && s.type == "Православный"
				select s;
				foreach (Happy g in happies)
				{
				Console.WriteLine("Праздник: " + g.prazdnik + "\t\t" + "Проходит: " + g.date + "\t\t" + g.type);
		        }

			Console.ReadKey();

		}
	}
}