using System;

namespace PR_6
{
    class Program
    {
        static void Main(string[] args)
        {

	string str = Console.ReadLine();
            string newstr = "";
            for (int i = str.Length - 1; i >= 0; i--)
                newstr += str[i];

            Console.WriteLine(str + "\t" + newstr);
            if(str == newstr)
            {
                Console.WriteLine("Строка является палиндромом");
            }else Console.WriteLine("Строка НЕ является палиндромом");

	
	/*string str = Console.ReadLine();
            ReverseString();

            Console.WriteLine(str +"\t|\t" + str);
	*/


        }

        /*public static string ReverseString()
        {
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            str = arr.ToString();
            Console.WriteLine(str);
            return new string(str);

            


        }*/

    }
}