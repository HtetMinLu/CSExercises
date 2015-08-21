using System;
namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
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
                    return count;
                }
                else
                {
                    return 0;
                }
            }
            temp = s1.Length;
            for (int i = 0; i < s1.Length; i++)
            {
                checkstop = temp - count;
               
                Check = s1.Substring(i, count);
                if (Check == s2)
                {
                    return i;
                }
                if ( checkstop < count)
                {
                    return 0;
                }
                temp = checkstop;
            }
            return 0;
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
                Int32 tmp = FindWord(first, second);
                Console.WriteLine(tmp);
               
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
   