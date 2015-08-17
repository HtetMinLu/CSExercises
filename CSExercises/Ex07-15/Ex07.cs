using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Double input,output;
            Console.Write("Please enter salary!");

            Boolean result = Double.TryParse(Console.ReadLine().ToString(), out input);
            if (result == false)
            {
                Console.WriteLine("Can't calculate.Please enter only number");
            }
            else
            {
                output = input + (input * 0.1) + (input * 0.03);
                Console.WriteLine("The total salary is: ${0:#.00} ", output);
            }
            Console.ReadLine();
        }
    }
}
