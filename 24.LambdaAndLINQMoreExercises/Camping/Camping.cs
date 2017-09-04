using System;
using System.Linq;
using System.Collections.Generic;

namespace Camping
{
    public class Camping
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var dictionary = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                var person = input[0];
                var camper = input[1];
                var days = int.Parse(input[2]);

                if (!dictionary.ContainsKey(person))
                {
                    dictionary[person] = new Dictionary<string, int>();
                }

                if (!dictionary[person].ContainsKey(camper))
                {
                    dictionary[person][camper] = 0;
                }

                dictionary[person][camper] = days;

                input = Console.ReadLine()
                .Split(' ')
                .ToList();
            }

            var orderedPersons = dictionary
                .OrderByDescending(x => x.Value.Keys.Count)
                .ThenBy(x => x.Key.Length);

            foreach (var person in orderedPersons)
            {
                Console.WriteLine($"{person.Key}: {person.Value.Keys.Count}");

                foreach (var camper in person.Value)
                {
                    Console.WriteLine($"***{camper.Key}");
                }

                Console.WriteLine($"Total stay: {person.Value.Values.Sum()} nights");
            }
        }
    }
}
