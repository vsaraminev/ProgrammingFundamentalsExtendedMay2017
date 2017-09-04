using System;
using System.Collections.Generic;
using System.Linq;

namespace Shellbound
{
    public class Shellbound
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var dictionary = new Dictionary<string, HashSet<int>>();

            while (input[0] != "Aggregate")
            {
                var region = input[0];
                var shellSize = int.Parse(input[1]);

                if (!dictionary.ContainsKey(region))
                {
                    dictionary[region] = new HashSet<int>();
                }

                dictionary[region].Add(shellSize);

                input = Console.ReadLine().Split(' ');
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(", ",item.Value)} ({item.Value.Sum() - (item.Value.Sum()/item.Value.Count)})");
            }
        }
    }
}
