using System;
using System.Linq;

namespace ArrayData
{
    public class ArrayData
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var average = numbers.Average();

            numbers = numbers
                .Where(n => n >= average)
                .ToList();

            var command = Console.ReadLine();

            switch (command)
            {
                case "Min":
                    Console.WriteLine(numbers.Min());
                    break;
                case "Max":
                    Console.WriteLine(numbers.Max());
                    break;
                case "All":
                    numbers = numbers
                        .OrderBy(n => n)
                        .ToList();
                    Console.WriteLine(string.Join(" ",numbers));
                    break;
            }
        }
    }
}
