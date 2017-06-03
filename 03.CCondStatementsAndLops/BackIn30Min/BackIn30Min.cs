using System;

namespace BackIn30Min
{
    public class BackIn30Min
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var resultMin = minutes + 30;
            var resultHours = hours;

            if (minutes + 30 > 59)
            {
                resultHours++;
                resultMin = (minutes + 30) % 60; 
            }
            if (resultHours>23)
            {
                resultHours = 0;                
            }

            Console.WriteLine($"{resultHours}:{resultMin:d2}");

        }
    }
}
