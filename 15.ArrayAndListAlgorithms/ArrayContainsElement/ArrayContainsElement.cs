using System;
using System.Linq;

namespace ArrayContainsElement
{
    public class ArrayContainsElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == n)
                {
                    isFound = true;
                    break;
                }                
            }

            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
