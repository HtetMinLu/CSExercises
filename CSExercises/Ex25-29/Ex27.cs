using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tX\t\tY");
            Console.WriteLine("\t---------------------------------------");
            for (int i = -5; i < 5; i++)
			{
			    Console.Write("\t\t{0:0.0}",i);
                Console.WriteLine("\t\t{0:0.0}", (2 * Math.Pow(i, 2)) - (4 * i) + 3);
			}
            Console.ReadLine();
        }
    }
}
