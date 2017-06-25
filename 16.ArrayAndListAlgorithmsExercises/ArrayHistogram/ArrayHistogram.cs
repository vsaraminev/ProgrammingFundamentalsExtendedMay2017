using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayHistogram
{
    public class ArrayHistogram
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToList();

            var resultWords = new List<string>();
            var resultCount = new List<double>();

            for (int i = 0; i < words.Count; i++)
            {
                var currentWord = words[i];

                if (resultWords.Contains(currentWord))
                {
                    var index = resultWords.IndexOf(currentWord);
                    resultCount[index]++;
                }
                else
                {
                    resultWords.Add(currentWord);
                    resultCount.Add(1);
                }
            }

            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < resultCount.Count - 1; i++)
                {
                    if (resultCount[i] < resultCount[i + 1])
                    {
                        var temp = resultCount[i];
                        resultCount[i] = resultCount[i + 1];
                        resultCount[i + 1] = temp;

                        var tempWord = resultWords[i];
                        resultWords[i] = resultWords[i + 1];
                        resultWords[i + 1] = tempWord;

                        swapped = true;
                    }
                }
            }

            for (int i = 0; i < resultWords.Count; i++)
            {
                var percentage = (resultCount[i] / words.Count) * 100;

                Console.WriteLine($"{resultWords[i]} -> {resultCount[i]} times ({percentage:f2}%)");

            }
        }
    }
}
