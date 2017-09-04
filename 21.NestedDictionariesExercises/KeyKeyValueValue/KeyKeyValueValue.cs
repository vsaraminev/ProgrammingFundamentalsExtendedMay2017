using System;
using System.Collections.Generic;

namespace KeyKeyValueValue
{
    public class KeyKeyValueValue
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var value = Console.ReadLine();

            var n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var currentLine = Console.ReadLine()
                    .Split(new[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var currentKey = currentLine[0];
                var currentValues = currentLine[1].Split(';');

                if (currentKey.Contains(key))
                {
                    dictionary[currentKey] = new List<string>();

                    foreach (var item in currentValues)
                    {
                        if (item.Contains(value))
                        {
                            dictionary[currentKey].Add(item);
                        }
                    }
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var findValue in item.Value)
                {
                    Console.WriteLine($"-{findValue}");
                }
            }
        }
    }
}
