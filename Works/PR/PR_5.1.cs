using System;

namespace PR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(double x = -100; x <=10; x += 2)
            {
                double f = Math.Cos(x) / Math.Sin(x) + 1;
                Console.WriteLine(x + "\t|\t" + f);
            }
        }
    }
}
