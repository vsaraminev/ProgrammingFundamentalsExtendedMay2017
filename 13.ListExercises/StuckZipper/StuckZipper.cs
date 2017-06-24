using System;
using System.Collections.Generic;
using System.Linq;

namespace StuckZipper
{
    public class StuckZipper
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var minLenght = GetMinLength(firstList, secondList);

            var filteredFirstList = new List<int>();
            var filteredSecondList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (GetNumberLength(firstList[i]) <= minLenght)
                {
                    filteredFirstList.Add(firstList[i]);
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (GetNumberLength(secondList[i]) <= minLenght)
                {
                    filteredSecondList.Add(secondList[i]);
                }
            }

            var result = new List<int>();

            for (int i = 0; i < Math.Max(filteredFirstList.Count,filteredSecondList.Count); i++)
            {
                if (i < filteredSecondList.Count)
                {
                    result.Add(filteredSecondList[i]);
                }
                if (i < filteredFirstList.Count)
                {
                    result.Add(filteredFirstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ",result));

        }

        public static int GetMinLength(List<int> firstList, List<int> secondList)
        {
            var minLength = int.MaxValue;

            for (int i = 0; i < firstList.Count; i++)
            {
                if (minLength > GetNumberLength(firstList[i]))
                {
                    minLength = GetNumberLength(firstList[i]);
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (minLength > GetNumberLength(secondList[i]))
                {
                    minLength = GetNumberLength(secondList[i]);
                }
            }

            return minLength;
        }

        public static int GetNumberLength(int number)
        {
            int digitCount = 0;

            number = Math.Abs(number);

            while (number > 0)
            {
                digitCount++;
                number /= 10;
            }

            return digitCount;
        }
    }
}
