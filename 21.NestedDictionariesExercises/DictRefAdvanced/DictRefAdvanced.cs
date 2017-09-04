using System;
using System.Linq;
using System.Collections.Generic;

namespace DictRefAdvanced
{
    public class DictRefAdvanced
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                var currentInput = input
                    .Split(new[] { "->", ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var key = currentInput[0];

                var number = 0;

                if (int.TryParse(currentInput[1], out number))
                {
                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new List<int>();
                    }

                    for (int i = 1; i < currentInput.Count; i++)
                    {
                        dictionary[key].Add(int.Parse(currentInput[i]));
                    }                    
                }
                else
                {
                    var anotherKye = currentInput[1];

                    if (dictionary.ContainsKey(anotherKye))
                    {
                        dictionary[key] = new List<int>(dictionary[anotherKye]);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var key in dictionary)
            {
                Console.WriteLine($"{key.Key} === {string.Join(", ", key.Value)}");
            }

        }
    }
}
