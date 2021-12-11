using System;

namespace PR10
{
	class Program
	{
		struct SportMan{
            	public string name;
            	public int age;
            	public string SportType;
            }
		
        public static void Main(string[] args)
        {
            /*Напишите программу, в которой содержатся данные о спортсменах:
 			ФИО и вид спорта (данные заполняются вами).
  			Выведите всех спортсменов, которые занимаются плаванием.*/
           
            
            
            SportMan[] people = new SportMan[50];
            
            people[0].name = "Иван";
            people[0].age = 20;
            people[0].SportType = "Биатлон";
            
            people[1].name = "Дмитрий";
            people[1].age = 21;
            people[1].SportType = "Плавание";
            
            people[2].name = "Антон";
            people[2].age = 20;
            people[2].SportType = "Плавание";
            
            Console.WriteLine("Введите номер спорта");
            int NumSport = int.Parse(Console.ReadLine());
            string StrSport = "";
            switch (NumSport) {
            	case 1:
            		StrSport = "Биатлон";
            		break;
            		
            	case 2:
            		StrSport = "Плавание";
            		break;
            	default:
            		
            		break;
            }
            
            
            for (int i = 0; i < people.Length; i++) {
            	if(people[i].SportType == StrSport){
            		Console.WriteLine("Имя: " + people[i].name + '\n' + 
            		                  "Возраст: " + people[i].age + '\n');
        	}
            }
		    
            /*
			Console.WriteLine("Имя: " + people[numberPeople].name + '\n' +  
                              "Возраст: " + people[numberPeople].age + '\n' +
                              "Вид спорта: " + people[numberPeople].SportType);
             */
			
            Console.ReadKey();
		}
	}
}