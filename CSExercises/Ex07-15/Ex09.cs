using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Double input, output;
            Console.Write("Please enter centigrate: ");

            Boolean result = Double.TryParse(Console.ReadLine().ToString(), out input);
            if (result == false)
            {
                Console.WriteLine("Can't calculate.Please enter only number");
            }
            else
            {
                output = (2 * Math.Pow(input, 2)) - (4 * input) + 3;
                Console.WriteLine("The value of y is: {0:#.##} ", output);
            }
            Console.ReadLine();
        }
    }
}
