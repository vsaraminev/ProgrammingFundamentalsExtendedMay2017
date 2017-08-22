using System;
using System.Text.RegularExpressions;

namespace Trainegram
{
    public class Trainegram
    {
        public static void Main()
        {
            var pattern = @"(^<\[[^A-Za-z0-9]*?\]\.)(\.\[[A-Za-z0-9]*?\]\.)*?$";

            var input = Console.ReadLine();

            while (input != "Traincode!")
            {
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
