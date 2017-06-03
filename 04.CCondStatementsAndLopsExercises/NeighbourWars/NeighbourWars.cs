using System;

namespace NeighbourWars
{
    public class NeighbourWars
    {
        public static void Main()
        {
            var PeshoDemage = int.Parse(Console.ReadLine());
            var GoshoDemage = int.Parse(Console.ReadLine());

            var PeshoHealth = 100;
            var GoshoHealth = 100;
            var count = 0;
            var round = 0;

            for (int i = 1; i < 100; i++)
            {
                round++;

                if (i % 2 != 0)
                {
                    GoshoHealth -= PeshoDemage;

                    if (GoshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                    }
                }
                else
                {
                    PeshoHealth -= GoshoDemage;

                    if (PeshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                    }
                }

                count++;

                if (count % 3 == 0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }
            }
        }
    }
}
