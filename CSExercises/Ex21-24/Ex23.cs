using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            Int32 result, count, gen;
            count = 0;
            gen = r.Next(0, 9);

            Console.Write(" Enter number: ");
            result = Convert.ToInt32(Console.ReadLine());

            while ( gen != result)
            {
                Console.Write(" Try again: ");
                result = Convert.ToInt32(Console.ReadLine());
                
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine("You are a Wizard!");
            }
            else if (count == 1)
            {
                 Console.WriteLine("You are a good guess!");
            }
            else if (count == 2)
            {
                Console.WriteLine("You are lousy!");
            }
            Console.ReadLine();
        }
    }
}
