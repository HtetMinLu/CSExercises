using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Double distance=0.0;
            Console.Write("Enter distance: ");
            distance = Convert.ToDouble(Console.ReadLine());
            distance = Math.Ceiling(distance * 10);
            if (distance < 9)
            {
                if ( distance > 5)
                {
                    Console.Write("The fare is $" + (2.4 + (85 * 0.04)));
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("The fare is $" + 2.4);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Write("The fare is $" + (2.4 + (85 * 0.04) + ( distance - 90) *0.05));
                Console.ReadLine();
            }
        }
    }
}