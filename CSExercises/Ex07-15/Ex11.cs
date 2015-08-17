using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Double input, output;
            Console.Write("Please enter distance!");

            Boolean result = Double.TryParse(Console.ReadLine().ToString(), out input);
            if (result == false)
            {
                Console.WriteLine("Can't calculate.Please enter only number");
            }
            else
            {
                output = (0.4 * input) + 2.4;
                Console.WriteLine("The total fare is: ${0:#.##} ", output);
            }
            Console.ReadLine();
        }
    }
}
