using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Int32 tv,dvd,mp3,temp = 0;
            Double total;
            Console.Write("Enter quantity for TV: ");
            tv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD: ");
            dvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3: ");
            mp3 = Convert.ToInt32(Console.ReadLine());
            if (((tv * 900) + (dvd * 500) + (mp3 * 700)) > 10000)
            {
                temp = (tv * 900) + (dvd * 500);
                total = (temp + (mp3 * 700)) - (temp * 0.15);
            }
            else if (((tv * 900) + (dvd * 500) + (mp3 * 700)) > 5000)
            {
                
                temp = (tv * 900) + (dvd * 500);
                total = (temp + (mp3 * 700)) - (temp * 0.1);
               
            }
            else
            {
                total = (tv * 900) + (dvd * 500) + (mp3 * 700);
            }

            Console.WriteLine("Total price for this order is " + total);
            Console.ReadLine();
        }
    }
}