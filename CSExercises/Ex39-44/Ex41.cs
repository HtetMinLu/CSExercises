using System;
namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
           
            int count = s2.Length;
            int checkstop, temp = 0;
            String Check="";
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();
            if (count == s1.Length)
            {
                Check = s1.Substring(0, count);
                if (Check == s2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            temp = s1.Length;
            for (int i = 0; i < s1.Length; i++)
            {
                checkstop = temp - count;
                if (true)
                {
                    
                }
                Check = s1.Substring(i, count);
                if (Check == s2)
                {
                    return true;
                }
                if ( checkstop < count)
                {
                    return false;
                }
                temp = checkstop;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter word!   ");
            String first = Console.ReadLine().TrimStart().TrimEnd();
            Console.Write("Enter word!   ");
            String second = Console.ReadLine().TrimStart().TrimEnd();

            if (first == "" || second == "")
            {
                Console.Write("No accept blank. Can't compare");
                return;
            }

            if ( first.Length >= second.Length)
            {
                Boolean tmp = InString(first, second);

                if (tmp == true)
                {
                    Console.Write("True");
                }
                else
                {
                    Console.Write("False");
                }
                Console.ReadLine();
            }
            else
            {
                Console.Write("Can't compare!");
                Console.ReadLine();
            }

           
        }
    }
}
