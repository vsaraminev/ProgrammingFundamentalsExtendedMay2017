using System;
using System.Collections.Generic;
using System.Linq;

namespace CottageScraper
{
   public class CottageScraper
    {
       public static void Main()
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, List<int>>();

            while (input != "chop chop")
            {
                var currentInput = input
                    .Split(new[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var tree = currentInput[0];
                var height = currentInput[1];

                if (!dictionary.ContainsKey(tree))
                {
                    dictionary[tree] = new List<int>();
                }

                dictionary[tree].Add(int.Parse(height));

                input = Console.ReadLine();
            }

            var CottageScraperTree = Console.ReadLine();
            var minLength = int.Parse(Console.ReadLine());

            var newDictionary = dictionary
                .Where(x => x.Key == CottageScraperTree)
                .ToDictionary(x => x.Key, x => x.Value);

            var result = new Dictionary<string, List<int>>();

            foreach (var item in newDictionary)
            {
                if (!result.ContainsKey(item.Key))
                {
                    result[item.Key] = new List<int>();
                }
                foreach (var lenght in item.Value.Where(x => x >= minLength))
                {
                    result[item.Key].Add(lenght);
                }
            }
            var sumTrees = dictionary.SelectMany(x => x.Value).Sum();

            var count = dictionary.Values.Sum(list => list.Count);

            double pricePerMeter = Math.Round(((double)sumTrees / count), 2);

            var sumUsedTree = result.SelectMany(x => x.Value).Sum();

            var usedLogs = pricePerMeter * sumUsedTree;

            var sumUnusedTrees = sumTrees - sumUsedTree;

            var unsedLogs = Math.Round(((double)sumUnusedTrees * pricePerMeter * 0.25), 2);

            var subTotal = Math.Round((usedLogs + unsedLogs), 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");

            Console.WriteLine($"Used logs price: ${usedLogs:f2}");

            Console.WriteLine($"Unused logs price: ${unsedLogs:f2}");

            Console.WriteLine($"CottageScraper subtotal: ${subTotal:f2}");
        }
    }
}
