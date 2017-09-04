using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace RegisteredUsers
{
    public class RegisteredUsers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dictionary = new Dictionary<string, DateTime>();

            while (input[0] != "end")
            {
                var userName = input[0];
                var userDate = DateTime.ParseExact(input[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                dictionary[userName] = userDate;

                input = Console.ReadLine()
                .Split(new[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            var result = dictionary
                .Reverse()  
                .OrderBy(x=>x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)                
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var name in result)
            {
                Console.WriteLine(name.Key);
            }
        }
    }
}
