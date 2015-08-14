using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Double total;
            Console.WriteLine("Please enter number!");

            Boolean result = Double.TryParse(Console.ReadLine().ToString(), out total);
            if (result == false)
            {
                Console.WriteLine("Can't calculate.Please enter only number");
            }
            else
            {
                Console.WriteLine("The square root of input number is " + Math.Sqrt(total));
            }
            Console.ReadLine();
        }
    }
}
