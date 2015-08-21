using System;
namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            
            Int32 val,count = 0;
            String[] tmp = new String[20];
            String result,result1="";
           
            if (i >= 16)
            {
                val = i;
                do
                {
                   
                    val = val / 16;
                    result = check(val);
                    tmp[count] = result;
                    count++;

                } while (val/16 > 0);

                result1 = check((i % 16));

                for (int j = count -1; j < 0; j--)
                {
                    result += tmp[j];
                }

                result = result + result1;
            }
            else
            {
                result = check(i);
            }

            return result;
        }

        public static String check(Int32 num)
        {
            String tmp;
            switch (num)
            {
                case 10:
                    tmp = "A";
                    break;
                case 11:
                    tmp = "B";
                    break;
                case 12:
                    tmp = "C";
                    break;
                case 13:
                    tmp = "D";
                    break;
                case 14:
                    tmp = "E";
                    break;
                case 15:
                    tmp = "F";
                    break;
                default:
                    tmp = num.ToString();
                    break;
            }
            return tmp;
        }

        public static void Main(string[] args)
        {
            String result;
            for (int i = 1; i <= 100; i++)
            {
                result = Hex(i);
                Console.WriteLine(i + "\t\t "+ result);
            }
            Console.ReadLine();
        }
    }
}
