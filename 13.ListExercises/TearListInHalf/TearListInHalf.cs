using System;
using System.Collections.Generic;
using System.Linq;

namespace TearListInHalf
{
    public class TearListInHalf
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var topList = new List<int>();
            var bottomList = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                bottomList.Add(numbers[i]);
            }

            for (int i = numbers.Count / 2; i < numbers.Count; i++)
            {
                topList.Add(numbers[i]);
            }

            var result = new List<int>();

            for (int i = 0; i < topList.Count; i++)
            {
                var currentNumTopList = topList[i];

                var firstNumTopList = currentNumTopList / 10;
                result.Add(firstNumTopList);

                result.Add(bottomList[i]);

                var secondNumTopList = currentNumTopList % 10;
                result.Add(secondNumTopList);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
