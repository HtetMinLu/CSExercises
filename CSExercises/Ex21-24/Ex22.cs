using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Int32 A, B, temp,temp2 = 0;
            Console.Write("Enter A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            B = Convert.ToInt32(Console.ReadLine());

            temp = A;
            temp2 = B;

            while ( temp != temp2)
            {
                if (temp > temp2)
                {
                    temp = temp - temp2;
                }
                else
                {

                    temp2 = temp2 - temp;
                }
            }

            Console.WriteLine("HCF:" + temp);
            Console.WriteLine("LCM:" + ((A*B)/temp));
            Console.ReadLine();
            //temp

        }
    }
}
