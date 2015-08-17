using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Double input, output;
            Console.Write("Please enter centigrate!");

            Boolean result = Double.TryParse(Console.ReadLine().ToString(), out input);
            if (result == false)
            {
                Console.WriteLine("Can't calculate.Please enter only number");
            }
            else
            {
                output = (1.8 * input) + 32;
                Console.WriteLine("Fahrenheit is: ${0:#.##} ", output);
            }
            Console.ReadLine();
        }
    }
}
