using System;

namespace DistanceOfTheStars
{
    public class DistanceOfTheStars
    {
        public static void Main()
        {
            decimal oneLightYearKm = 9450000000000M;

            decimal distanceEarthToNearestStar = 4.22M * oneLightYearKm;

            decimal distanceCenterOurGalaxy = 26000 * oneLightYearKm;

            decimal diameterMilkyWay = 100000 * oneLightYearKm;

            decimal distanceEarthToUniverse = 46500000000 * oneLightYearKm;
            
            Console.WriteLine($"{distanceEarthToNearestStar:e2}");
            Console.WriteLine($"{distanceCenterOurGalaxy:e2}");
            Console.WriteLine($"{diameterMilkyWay:e2}");
            Console.WriteLine($"{distanceEarthToUniverse:e2}");
        }
    }
}
