using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            Boolean tmp = true;
            for (int i = 5; i < 10000; i++)
            {   
                for (int j = 2; j < i; j++)
                {
                    if (i%j == 0)
                    {
                        tmp = false;
                        break;
                    }
                   
                }
                if (tmp == true)
                {
                    Console.WriteLine(i);
                }
                tmp = true;
            }
            Console.ReadLine();
        }
    }
}
