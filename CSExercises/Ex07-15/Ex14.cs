using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Double a, b, c, output;
            Console.Write("Please enter first length: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter second length: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter third length: ");
            c = Convert.ToDouble(Console.ReadLine());

            output = (a + b + c) / 2;
            output = Math.Sqrt(output * (output -a ) * (output - b) * (output - c));
            Console.WriteLine("The result is: " + output);
            Console.ReadLine();
        
        }
    }
}