using System;
using System.Linq;
using System.Collections.Generic;

namespace DecodeRadioFrequencies
{
    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToList();

            var result = new List<char>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var freq = new string[2];
                freq = numbers[i].Split('.');

                var leftPart = int.Parse(freq[0]);
                var rightPart = int.Parse(freq[1]);

                if (leftPart != 0)
                {
                    result.Insert(i, (char)leftPart);
                }
                if (rightPart != 0)
                {
                    result.Insert(result.Count - i, (char)rightPart);
                }  
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
