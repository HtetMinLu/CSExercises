using System;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 26; i++)
            {
                double sqrtResult = SQT(i);
                Console.WriteLine("The square root of {0} is {1} ", i, sqrtResult);
            }
        }

        public static double SQT(int y)
        {
            //GetRandomNumberBetween1and25
            Random r = new Random();
            double x = r.NextDouble();
            x = x * (y - 1);
            x = x + 1;

            //Formula to find square root >>> G = (G + N/G)/2;
            double returnResult = (x + (y / x)) / 2;

            return returnResult;
        }
    }
}
