using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            Int32 val = Convert.ToInt32(Console.ReadLine());
            if (val == 2 && val==3)
            {
                Console.WriteLine("Prime");
                Console.ReadLine();
                return;
                
            }
            if (val%2 == 0 & val == 1 || val == 0)
            {
                Console.WriteLine("Not Prime");
                Console.ReadLine();
                return;
                
            }

            for (int i = 3; i < val; i = i + 2)
            {
                if (val % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    Console.ReadLine();
                    return;
                    
                }
            }
            Console.WriteLine("Prime");


            Console.ReadLine();
        }
    }
}
