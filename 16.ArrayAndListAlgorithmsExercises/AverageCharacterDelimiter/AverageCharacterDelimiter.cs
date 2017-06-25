using System;
using System.Linq;

namespace AverageCharacterDelimiter
{
    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var sumElemenst = 0;
            var countElements = 0;

            for (int i = 0; i < input.Count; i++)
            {
                countElements += input[i].Count();

                var currentSum = 0;

                foreach (var item in input[i])
                {
                    currentSum += item;
                }

                sumElemenst += currentSum;
            }

            var average = sumElemenst / countElements;
            var symbol = (char)average;
            var upperSymbol = char.ToUpper(symbol);

            Console.WriteLine(string.Join($"{upperSymbol}",input));                   
        }
    }
}
