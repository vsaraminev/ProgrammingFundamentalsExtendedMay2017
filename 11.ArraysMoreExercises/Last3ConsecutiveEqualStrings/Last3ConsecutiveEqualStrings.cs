using System;
using System.Linq;

namespace Last3ConsecutiveEqualStrings
{
    public class Last3ConsecutiveEqualStrings
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var reversedText = text.Reverse().ToArray();

            var firstString = reversedText[0];

            int count = 1;

            for (int i = 1; i < reversedText.Length; i++)
            {
                if (firstString == reversedText[i])
                {
                    count++;                    
                }
                else
                {
                    count = 1;
                    firstString = reversedText[i];
                }

                if (count == 3)
                {
                    Console.WriteLine($"{reversedText[i]} {reversedText[i]} {reversedText[i]}");
                    break;
                }
               
            }            
        }
    }
}
