using System;
using System.Linq;
using System.Collections.Generic;

namespace MirrorImage
{
    public class MirrorImage
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var line = Console.ReadLine();

            while (line != "Print")
            {
                var index = int.Parse(line);
                var element = input[index];

                var prevList = input.Take(index).ToList();
                prevList.Reverse();
                var afterList = input.Skip(index + 1).ToList();
                afterList.Reverse();

                var result = new List<string>();

                result.AddRange(prevList);
                result.Add(element);
                result.AddRange(afterList);

                input = result;

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",input));

        }
    }
}
