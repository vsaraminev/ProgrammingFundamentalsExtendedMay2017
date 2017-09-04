using System;
using System.Linq;

namespace StringDecryption
{
    public class StringDecryption
    {
        public static void Main()
        {
            var input = Console.ReadLine()
               .Split(' ')
               .ToList();

            var skip = int.Parse(input[0]);
            var take = int.Parse(input[1]);

            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers = numbers
                .Where(n => n >= 65 && n <= 90)
                .Skip(skip)
                .Take(take)
                .ToList();

            foreach (var item in numbers)
            {
                Console.Write((char)item);
            }

            Console.WriteLine();
        }
    }
}
