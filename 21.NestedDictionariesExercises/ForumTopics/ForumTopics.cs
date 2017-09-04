using System;
using System.Collections.Generic;
using System.Linq;

namespace ForumTopics
{
    public class ForumTopics
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { "->", " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dictionary = new Dictionary<string, HashSet<string>>();

            while (input[0] != "filter")
            {
                var topic = input[0];

                if (!dictionary.ContainsKey(topic))
                {
                    dictionary[topic] = new HashSet<string>();
                }

                for (int i = 1; i < input.Count; i++)
                {
                    dictionary[topic].Add(input[i]);
                }

                input = Console.ReadLine()
                .Split(new[] { "->", " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            var tagsLine = Console.ReadLine()
                .Split(new[] { ' ', ','},StringSplitOptions.RemoveEmptyEntries);

            foreach (var tag in dictionary)
            {
                bool isFound = false;

                foreach (var item in tagsLine)
                {
                    if (tag.Value.Contains(item))
                    {
                        isFound = true;
                    }
                    else
                    {
                        isFound = false;
                        break;
                    }
                }

                if (isFound)
                {
                    Console.WriteLine($"{tag.Key} | #{string.Join(", #",tag.Value)}");
                }

            }
        }
    }
}
