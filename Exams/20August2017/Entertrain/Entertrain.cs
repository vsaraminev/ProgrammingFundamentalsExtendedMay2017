using System;
using System.Collections.Generic;
using System.Linq;

namespace Entertrain
{
    public class Entertrain
    {
        public static void Main()
        {
            var locPower = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();

            var wagons = new List<int>();

            while (input != "All ofboard!")
            {
                var wagonWeight = int.Parse(input);

                var averageWeeight = 0;

                wagons.Add(wagonWeight);

                var wagonsSum = wagons.Sum();

                if (wagonsSum > locPower)
                {
                    averageWeeight = (int)(wagons.Average());

                    int closest = wagons.OrderBy(item => Math.Abs(averageWeeight - item)).First();
                    var closestIndex = wagons.IndexOf(closest);
                    wagons.RemoveAt(closestIndex);
                }

                input = Console.ReadLine();
            }

            wagons.Reverse();
            wagons.Add(locPower);

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
