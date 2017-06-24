using System;
using System.Linq;

namespace SortArrayUsingBubbleSort
{
    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    var currentNum = numbers[i];
                    var nextNum = numbers[i + 1];

                    if (currentNum > nextNum)
                    {
                        numbers[i + 1] = currentNum;
                        numbers[i] = nextNum;

                        swapped = true;
                    }
                }

            } while (swapped);

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}




