using System;
using System.Collections.Generic;

namespace LetterRepetition
{
    public class LetterRepetition
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            var dictionary = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary[item] = 0;
                }

                dictionary[item]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
