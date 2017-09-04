using System;
using System.Collections.Generic;

namespace UserLogins
{
    public class UserLogins
    {
        public static void Main()
        {
            var input = Console.ReadLine()
               .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = new Dictionary<string, string>();

            while (input[0] != "login")
            {
                dictionary[input[0]] = input[1];

                input = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var count = 0;

            while (input[0] != "end")
            {
                if (dictionary.ContainsKey(input[0]))
                {
                    if (input[1] == dictionary[input[0]])
                    {
                        Console.WriteLine($"{input[0]}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]}: login failed");
                        count++;
                    }
                }
                else if (input[0] != "login")
                {
                    Console.WriteLine($"{input[0]}: login failed");
                    count++;
                }

                input = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
