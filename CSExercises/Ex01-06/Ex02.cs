using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Int32 total;
            Console.WriteLine("Please enter number!");
            
            Boolean result = Int32.TryParse(Console.ReadLine().ToString(), out total);
            if (result == false)
            {
                Console.WriteLine("Can't calculate.Please enter only number");
            }
            else
            {
                Console.WriteLine("The square of input number is " + total * total);
            }
            Console.ReadLine();
        }
    }
}
