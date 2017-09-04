using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var dictionary = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 0;
                }

                dictionary[number]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
