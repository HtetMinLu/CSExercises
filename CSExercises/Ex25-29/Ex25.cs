using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Write a factorial!");
            Int32 val,temp, temp1 = 1;
            val   = Convert.ToInt32(Console.ReadLine());
            temp = 1;
            for (int i = val; 0 < i; i--)
            {
                temp = temp * i;
            }

            for (int i = 1; i <= val; i++)
            {
                 temp1 = temp1 * i;
            }

            Console.WriteLine("Increatement counter: " + temp1);
            Console.WriteLine("Decreasement counter: " + temp);
            Console.ReadLine();
        }
    }
}
