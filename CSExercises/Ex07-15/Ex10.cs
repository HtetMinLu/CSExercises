using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Double x1,x2,y1,y2, output;
            Console.Write("Please enter x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            try
            {
                output = Math.Sqrt((x2-x1)+(y2-y1));
                Console.WriteLine("The distance is: {0:0.####} ", output);
            }
            catch (Exception)
            {
                Console.WriteLine("Can't calculate.Please enter only number");
            }
            Console.ReadLine();
        }
    }
}
