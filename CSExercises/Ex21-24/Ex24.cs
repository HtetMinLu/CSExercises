using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Int32 input;
            Double guess;

            Console.Write("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());


            Random r = new Random();
           guess = r.Next(1, input);

            if (input != (guess* guess))
            {
                
            }

        }
    }
}
