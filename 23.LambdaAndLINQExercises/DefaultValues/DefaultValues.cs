using System;
using System.Linq;
using System.Collections.Generic;

namespace DefaultValues
{
    public class DefaultValues
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dictionary = new Dictionary<string, string>();

            while (input[0] != "end")
            {
                var key = input[0];
                var value = input[1];

                if (!dictionary.ContainsKey(key))
                {
                    dictionary[key] = "";
                }

                dictionary[key] = value;

                input = Console.ReadLine()
                .Split(new[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            var command = Console.ReadLine();

            var unchanged = dictionary
                 .Where(x => x.Value != "null")
                 .OrderByDescending(x => x.Value.Length)
                 .ToDictionary(x => x.Key, x => x.Value);

            var replaced = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => command);

            foreach (var item in unchanged)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }

            foreach (var item in replaced)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
