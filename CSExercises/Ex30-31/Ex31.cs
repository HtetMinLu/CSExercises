using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            
            Int32 count = 0;

            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count += j;
                    }
                }
                if (count == i)
                {
                    Console.WriteLine(i);
                }
                count = 0;
            }
            
            Console.ReadLine();
            
        }
    }
}
