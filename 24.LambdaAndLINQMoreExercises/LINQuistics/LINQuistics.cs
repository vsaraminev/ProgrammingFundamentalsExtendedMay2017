using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQuistics
{
    public class LINQuistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, List<string>>();

            while (input != "exit")
            {
                var currentInput = input
                    .Split(new[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                if (currentInput.Length == 1)
                {
                    var number = 0;

                    if (int.TryParse(currentInput[0], out number))
                    {
                        var mostMethods = dictionary
                            .OrderByDescending(x => x.Value.Count)
                            .Take(1)
                            .ToDictionary(x => x.Key, x => x.Value);

                        var count = 0;

                        foreach (var method in mostMethods)
                        {
                            foreach (var item in method.Value.OrderBy(x => x.Length))
                            {
                                if (count < number)
                                {
                                    Console.WriteLine($"* {item}");
                                    count++;
                                }
                            }
                        }
                    }
                    if (dictionary.ContainsKey(currentInput[0]))
                    {
                        var currentColl = currentInput[0];

                        var currenrCollList = dictionary[currentColl]
                            .OrderByDescending(x => x.Length)
                            .ThenByDescending(x => x.Distinct().Count()).ToList();

                        foreach (var method in currenrCollList)
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                }
                else
                {
                    var collection = currentInput[0];

                    var methods = currentInput
                        .Skip(1)
                        .ToList();

                    if (!dictionary.ContainsKey(collection))
                    {
                        dictionary[collection] = new List<string>();
                    }

                    foreach (var method in methods)
                    {
                        if (!dictionary[collection].Contains(method))
                        {
                            dictionary[collection].Add(method);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var lastLine = Console.ReadLine()
                .Split(' ').ToList();

            var finalMethod = lastLine[0];
            var selection = lastLine[1];

            var finalDict = dictionary.Where(x => x.Value.Contains(finalMethod)).ToDictionary(x => x.Key, x => x.Value);

            foreach (var collection in finalDict.OrderByDescending(x => x.Value.Count)
                                                .ThenByDescending(x => x.Value.Min(y => y.Length)))
            {
                if (selection == "collection")
                {
                    Console.WriteLine($"{collection.Key}");
                }
                else if (selection == "all")
                {
                    Console.WriteLine($"{collection.Key}");

                    foreach (var methods in collection.Value.OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($"* {methods}");
                    }
                }
            }
        }
    }
}
