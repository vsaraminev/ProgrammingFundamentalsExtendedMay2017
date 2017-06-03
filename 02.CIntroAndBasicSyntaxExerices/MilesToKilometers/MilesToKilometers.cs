using System;

namespace MilesToKilometers
{
    public class MilesToKilometers
    {
        public static void Main()
        {
            var miles = double.Parse(Console.ReadLine());
            var km = miles * 1.60934;

            Console.WriteLine($"{km:f2}");
        }
    }
}
