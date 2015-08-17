using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            String name, gender;
            Console.Write("Please enter name: ");
            name = Console.ReadLine();
            Console.Write("Please enter gender: ");
            gender = Console.ReadLine();
            if (gender == "M")
            {
                 Console.Write("Good morning Mr." + name);
            }
            else
            {
                Console.Write("Good morning Ms." + name);
            }
            Console.ReadLine();
        }
    }
}