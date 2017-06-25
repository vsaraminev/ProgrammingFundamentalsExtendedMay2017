using System;
using System.Linq;

namespace SortArrayOfStrings
{
    public class SortArrayOfStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i].CompareTo(input[i + 1]) == 1)
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;

                        swapped = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
