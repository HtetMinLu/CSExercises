using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number!");
            Int32 count = 0;
            Int32 val = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < val; i++)
            {
                if (val%i == 0)
                {
                    count += i;
                }
            }
            if (count == val)
            {
                Console.WriteLine(val + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(val + " is not Perfect Number");
            }
            Console.ReadLine();
        }
    }
}
