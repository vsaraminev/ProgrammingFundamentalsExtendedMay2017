using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestElementInArray
{
    public class SmallestElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            // Console.WriteLine(numbers.Min()); 

            var smallestElement = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (smallestElement > numbers[i])
                {
                    smallestElement = numbers[i];
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
