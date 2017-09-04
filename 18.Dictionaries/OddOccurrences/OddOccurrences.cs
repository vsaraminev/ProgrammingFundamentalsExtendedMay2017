using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(' ');

            var dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = 0;
                }

                dictionary[word]++;
            }

            var result = new List<string>();

            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
