using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            Int32 val = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            for (int i = 2; i <= val; i = i +2)
            {
                if (i == val)
                {
                    Console.WriteLine(val + " is Perfect Number");
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine(val + " is Not Perfect Number");
            }
            Console.ReadLine();
        }
    }
}
