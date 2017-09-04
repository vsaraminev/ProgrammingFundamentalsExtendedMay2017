using System;
using System.Collections.Generic;

namespace Wardrobe
{
    public class Wardrobe
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                  .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                string[] clothes = input[1].Split(',');

                foreach (var cloth in clothes)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color][cloth] = 0;
                    }
                    wardrobe[color][cloth]++;
                }
            }
            string[] inputLine = Console.ReadLine().Split(' ');
            foreach (var cloth in wardrobe)
            {
                string color = cloth.Key;
                Console.WriteLine($"{color} clothes:");
                foreach (var kvp in cloth.Value)
                {
                    Console.Write($"* {kvp.Key} - {kvp.Value}");
                    if (color == inputLine[0] && kvp.Key == inputLine[1])
                    {
                        Console.Write($" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
