using System;
using System.Linq;
using System.Collections.Generic;

namespace Extremums
{
    public class Extremums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();

            var result = new List<int>();

            var minValue = int.MaxValue;
            var maxValue = int.MinValue;

            var sum = 0;

            if (command == "Min")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    var currentNum = numbers[i];
                    var strCurrentNum = currentNum.ToString();

                    var count = 0;

                    while (count <= strCurrentNum.Length)
                    {
                        if (currentNum < minValue)
                        {
                            minValue = currentNum;
                        }

                        strCurrentNum = GetRverseMethod(strCurrentNum);
                        currentNum = int.Parse(strCurrentNum);
                        count++;
                    }

                    result.Add(minValue);
                    sum += minValue;
                    minValue = int.MaxValue;
                }
            }

            if (command == "Max")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    var currentNum = numbers[i];
                    var strCurrentNum = currentNum.ToString();

                    var count = 0;

                    while (count <= strCurrentNum.Length)
                    {
                        if (currentNum > maxValue)
                        {
                            maxValue = currentNum;
                        }

                        strCurrentNum = GetRverseMethod(strCurrentNum);
                        currentNum = int.Parse(strCurrentNum);
                        count++;
                    }

                    result.Add(maxValue);
                    sum += maxValue;
                    maxValue = int.MinValue;
                }
            }

            Console.WriteLine(string.Join(", ",result));
            Console.WriteLine(sum);

        }

        public static string GetRverseMethod(string strCurrentNum)
        {
            var firstChar = strCurrentNum.Substring(0, 1);
            var reversed = strCurrentNum.Substring(1) + firstChar;

            return reversed;
        }
    }
}
