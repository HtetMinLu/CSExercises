using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Int32 mark = 0;
            Console.Write("Enter your score");
            mark = Convert.ToInt32(Console.Read());
            if ( mark > 0 && mark < 0)
            {
                if (mark < 40)
                {
                    Console.Write("Your scored {0} marks which is F grade.", mark);
                }
                else if ( mark < 60)
                {
                    Console.Write("Your scored {0} marks which is C grade.", mark);
                }
                else if ( mark < 80)
                {
                    Console.Write("Your scored {0} marks which is B grade.", mark);
                }
                else
                {
                    Console.Write("Your scored {0} marks which is A grade.", mark);
                }
            }
            else
            {
                Console.WriteLine("***Error***");
            }
            Console.ReadLine();
        }
    }
}