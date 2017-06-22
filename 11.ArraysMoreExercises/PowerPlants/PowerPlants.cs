using System;
using System.Linq;

namespace PowerPlants
{
    public class PowerPlants
    {
        public static void Main()
        {
            var flowers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var daysInSeason = flowers.Length;

            int daysComplete = 0;

            while (AreFlowersAlive(flowers))
            {
                for (int i = 0; i < flowers.Length; i++)
                {
                    if (flowers[i] != 0)
                    {
                        if (daysComplete % daysInSeason != i)
                        {
                            flowers[i]--;
                        }
                    }
                }

                daysComplete++;

                if (daysComplete % daysInSeason == 0)
                {
                    for (int i = 0; i < flowers.Length; i++)
                    {
                        if (flowers[i] != 0)
                        {
                            flowers[i]++;
                        }
                    }
                }                
            }
            var seasons = (daysComplete-1) / daysInSeason;

            Console.WriteLine($"survived {daysComplete} days ({seasons} seasons)");
        }

        public static bool AreFlowersAlive(int[] flowers)
        {
            for (int i = 0; i < flowers.Length; i++)
            {
                if (flowers[i] > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
