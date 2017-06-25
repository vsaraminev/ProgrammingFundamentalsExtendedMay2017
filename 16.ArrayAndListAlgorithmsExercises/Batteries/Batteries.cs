using System;
using System.Linq;

namespace Batteries
{
    public class Batteries
    {
        public static void Main()
        {
            var capacities = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var usage = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var hours = double.Parse(Console.ReadLine());

            for (int i = 0; i < capacities.Count; i++)
            {
                var capacity = capacities[i] - (usage[i]*hours);
                var percentage = (capacity / capacities[i])*100;

                if (capacity > 0)
                {
                    Console.WriteLine($"Battery {i+1}: {capacity:f2} mAh ({percentage:f2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i+1}: dead (lasted {Math.Ceiling(capacities[i]/usage[i])} hours)");
                }
            }
        }
    }
}
