using System;

namespace TravelintAtLightSpeed
{
    public class TravelintAtLightSpeed
    {
        public static void Main()
        {
            decimal ligthYears = decimal.Parse(Console.ReadLine());

            decimal distance = ligthYears * 9450000000000;

            decimal totalTimeSec = distance / 300000;

            decimal seconds = Math.Floor(totalTimeSec % 60);

            decimal timeMin = totalTimeSec / 60;          

            decimal minutes = (int)timeMin % 60;

            decimal timeHours = timeMin / 60;

            decimal hours = (int)timeHours % 24;

            decimal timeDays = timeHours / 24;

            decimal days = (int)timeDays % 7;

            decimal weeks = (int)timeDays / 7;        

             Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{seconds} seconds");
        }
    }
}
