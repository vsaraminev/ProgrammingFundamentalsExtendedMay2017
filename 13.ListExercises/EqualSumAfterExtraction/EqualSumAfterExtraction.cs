using System;
using System.Linq;

namespace EqualSumAfterExtraction
{
   public class EqualSumAfterExtraction
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

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    secondList.Remove(firstList[i]);
                }
            }

            var firstSum = firstList.Sum();
            var secondSum = secondList.Sum();

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstSum-secondSum)}");
            }
        }
    }
}
