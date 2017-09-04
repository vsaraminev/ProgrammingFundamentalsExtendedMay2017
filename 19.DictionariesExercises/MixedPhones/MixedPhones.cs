using System;
using System.Collections.Generic;

namespace MixedPhones
{
    public class MixedPhones
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = new SortedDictionary<string, long>();

            while (input[0] != "Over")
            {
                var key = input[0];
                var value = input[1];

                long number = 0;

                if (long.TryParse(key, out number))
                {
                    dictionary[value] = number;
                }
                else
                {
                    dictionary[key] = long.Parse(value);
                }

                input = Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
