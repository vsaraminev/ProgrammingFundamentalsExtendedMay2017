using System;
namespace Trainers
{
    public class Trainers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var fuelPrice = 2.5;
            var cargoPrice = 1.5;

            var technicalTotal = 0.0;
            var theoreticalTotal = 0.0;
            var practicalTotal = 0.0;

            var resultTeamName = "";

            for (int i = 0; i < n; i++)
            {
                var distanceMiles = int.Parse(Console.ReadLine());
                var cargoTones = double.Parse(Console.ReadLine());
                var teamName = Console.ReadLine();

                var distanceInMeters = distanceMiles * 1600;
                var cargoKg = cargoTones * 1000;

                double fuelCons = 0.7 * distanceInMeters * fuelPrice;

                var cargoMoney = cargoPrice * cargoKg;

                var teamCoast = cargoMoney - fuelCons;

                if (teamName == "Technical")
                {
                    technicalTotal += teamCoast;
                }
                else if (teamName == "Theoretical")
                {
                    theoreticalTotal += teamCoast;
                }
                else if (teamName == "Practical")
                {
                    practicalTotal += teamCoast;
                }
            }

            var firstRes = Math.Max(technicalTotal, theoreticalTotal);

            if (firstRes == technicalTotal)
            {
                resultTeamName = "Technical";
            }
            else
            {
                resultTeamName = "Theoretical";
            }

            var result = Math.Max(firstRes, practicalTotal);

            if (result == practicalTotal)
            {
                resultTeamName = "Practical";
            }

            Console.WriteLine($"The {resultTeamName} Trainers win with ${result:f3}.");
        }
    }
}
