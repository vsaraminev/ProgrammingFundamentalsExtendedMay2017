using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderedBankingSystem
{
    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dictionary = new Dictionary<string, Dictionary<string, decimal>>();

            while (input[0] != "end")
            {
                var bank = input[0];
                var account = input[1];
                var balance = decimal.Parse(input[2]);

                if (!dictionary.ContainsKey(bank))
                {
                    dictionary[bank] = new Dictionary<string, decimal>();
                }
                if (!dictionary[bank].ContainsKey(account))
                {
                    dictionary[bank][account] = 0;
                }

                dictionary[bank][account] += balance;


                input = Console.ReadLine()
                .Split(new[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            var ordered = dictionary
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Max())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var bank in ordered)
            {
                foreach (var account in bank.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
                }
            }
        }
    }
}
