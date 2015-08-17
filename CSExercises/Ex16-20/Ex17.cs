using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            String name, gender;
            Int32 age;
            Console.Write("Please enter name: ");
            name = Console.ReadLine();
            Console.Write("Please enter gender: ");
            gender = Console.ReadLine();
            Console.Write("Please enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 40)
            {
                if (gender == "M")
                {
                    Console.Write("Good morning Mr." + name);    
                }
                else
                {
                    Console.Write("Good morning Ms." + name);
                }
            }
            else
            {
                if (gender == "M")
                {
                    Console.Write("Good morning Uncle " + name);
                }
                else
                {
                    Console.Write("Good morning Aunty" + name);
                }
            }
            Console.ReadLine();
        }
    }
}