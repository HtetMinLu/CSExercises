using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number!");
            Int32 val = Convert.ToInt32(Console.ReadLine());
            if ( val == 2 || val == 3)
            {
                Console.WriteLine("Prime");
                return;
            }
            if ( val == 0)
            {
                Console.WriteLine(" Not Prime");
                return;
            }
            if ((val % 2) == 0 || (val % 3 == 0))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine(" Not Prime");
            }
            Console.ReadLine();
        }
    }
}
