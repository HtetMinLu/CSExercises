using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Int32 count = 0;
            Console.WriteLine("\t\tX\t\tY");
            Console.WriteLine("\t---------------------------------------");
            for (int i = -4; i < 5; i++)
			{
			    Console.Write("\t\t{0:0.0}",i);
                Console.WriteLine("\t\t{0:0.0}", (2 * Math.Pow(i, 2)) - (4 * i) + 3);
			}

            Int32 a;
            for (int i = -4; i < 5; i++)
			{
                a = (2 * i * i) - (4 * i) + 3;
                for (int j = 1; j <= a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
			}
            
            Console.ReadLine();
        }
    }
}
