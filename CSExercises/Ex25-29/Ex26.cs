using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("No\t\tINVERSE\t\tSQUAREROOT\t\tSQUARE");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0:0.0}\t\t{1:0.0##}\t\t{2:#.0##}\t\t\t{3:#.0##}",i,1.0/i,Math.Sqrt(i),Math.Pow(i,2));
            }
            Console.ReadLine();
        }
    }
}
