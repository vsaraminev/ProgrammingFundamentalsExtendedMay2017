using System;
using System.Linq;
using System.Collections.Generic;

namespace Lambada
{
    public class Lambada
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { "=>", ".", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (input[0] != "lambada")
            {
                if (input[0] == "dance")
                {
                    dictionary = dictionary
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                          .ToDictionary(selObject => selObject.Key, selObject => selObject.Key + "." + selObject.Value));
                }
                else
                {
                    var selector = input[0];
                    var selObject = input[1];
                    var property = input[2];

                    if (!dictionary.ContainsKey(selector))
                    {
                        dictionary[selector] = new Dictionary<string, string>();
                    }

                    if (!dictionary[selector].ContainsKey(selObject))
                    {
                        dictionary[selector][selObject] = "";
                    }

                    dictionary[selector][selObject] = property;
                }

                input = Console.ReadLine()
                .Split(new[] { "=>", ".", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            foreach (var selector in dictionary)
            {
                foreach (var selObject in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {selObject.Key}.{selObject.Value}");
                }
            }
        }
    }
}
