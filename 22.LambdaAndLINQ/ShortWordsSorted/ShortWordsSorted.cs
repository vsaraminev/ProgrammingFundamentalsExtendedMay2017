using System;
using System.Linq;

namespace ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                  .ToLower()
                  .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

            var words = input
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
