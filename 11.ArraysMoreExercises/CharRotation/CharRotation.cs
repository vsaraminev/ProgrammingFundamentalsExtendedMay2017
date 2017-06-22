using System;
using System.Linq;

namespace CharRotation
{
    public class CharRotation
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .ToCharArray();

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                var sum = 0;

                if (numbers[i] % 2 == 0)
                {
                    sum += text[i] - numbers[i];
                }
                else
                {
                    sum += text[i] + numbers[i];
                }

                result[i] = sum;
            }

            foreach (var item in result)
            {
                Console.Write((char)item);
            }
            Console.WriteLine();
        }
    }
}
