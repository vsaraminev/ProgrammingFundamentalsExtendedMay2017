using System;
using System.Linq;

namespace SortArrayUsingInsertionSort
{
    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length-1; i++)
            {
                var j = i + 1;

                while (j > 0)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;

                    }
                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
