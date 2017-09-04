using System;
using System.Linq;

namespace FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var k = input.Length / 4;

            var leftSide = input.Take(k).Reverse().ToArray();
            var rightSide = input.Reverse().Take(k).ToArray();

            var topArr = leftSide.Concat(rightSide).ToArray();

            var downArr = input.Skip(k).Take(2 * k).ToArray();
            
            var result = new int[2 * k];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(topArr[i]) + int.Parse(downArr[i]);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
