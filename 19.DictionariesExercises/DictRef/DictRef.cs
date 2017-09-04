using System;
using System.Collections.Generic;

namespace DictRef
{
    public class DictRef
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                var key = input[0];
                var value = input[1];

                var number = 0;

                if (int.TryParse(value, out number))
                {
                    dictionary[key] = number;
                }
                else
                {
                    if (dictionary.ContainsKey(value))
                    {
                        dictionary[key] = dictionary[value];
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
