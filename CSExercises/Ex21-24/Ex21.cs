using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            Int32 result = 0;
            
            while ( result != 88)
            {
                Console.Clear();
                Console.Write("Enter number: ");
                result = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Lucky you...");
            Console.ReadLine();
        }
    }
}
