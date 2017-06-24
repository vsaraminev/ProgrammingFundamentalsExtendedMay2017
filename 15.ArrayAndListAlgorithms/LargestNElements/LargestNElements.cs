using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNElements
{
    public class LargestNElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            var count = 0;

            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (count < n)
                {
                    result.Add(numbers[i]);
                    count++;
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
