using System;

namespace SumOfOddNumbers
{
    public class SumOfOddNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var count = 0;
            var sum = 0;

            for (int i = 1; i < int.MaxValue; i++)
            {
                if (i % 2 != 0)
                {
                    if (count < n)
                    {
                        count++;
                        sum += i;
                        Console.WriteLine(i);
                    }
                    else
                    {
                        break;
                    }
                }                                       
               
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
