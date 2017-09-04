using System;
using System.Collections.Generic;
using System.Linq;

namespace FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (input[0] != "end")
            {
                if (input[0] == "flatten")
                {
                    var flattenKey = input[1];

                    dictionary[flattenKey] = dictionary[flattenKey]
                        .ToDictionary(x => x.Key + x.Value, x => "flatten");
                }
                else
                {
                    var key = input[0];
                    var innerKey = input[1];
                    var inneValue = input[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }

                    if (!dictionary[key].ContainsKey(innerKey))
                    {
                        dictionary[key][innerKey] = "";
                    }

                    dictionary[key][innerKey] = inneValue;
                }

                input = Console.ReadLine()
                .Split(' ')
                .ToList();
            }

            dictionary = dictionary
            .OrderByDescending(x => x.Key.Length)
            .ToDictionary(x => x.Key, x => x.Value);

            var count = 1;

            foreach (var key in dictionary)
            {
                Console.WriteLine($"{key.Key}");

                foreach (var innerKey in key.Value.Where(x => x.Value != "flatten").OrderBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{count}. {innerKey.Key} - {innerKey.Value}");
                    count++;
                }

                foreach (var item in key.Value.Where(x => x.Value == "flatten"))
                {
                    Console.WriteLine($"{count}. {item.Key}");
                    count++;
                }

                count = 1;
            }
        }
    }
}
