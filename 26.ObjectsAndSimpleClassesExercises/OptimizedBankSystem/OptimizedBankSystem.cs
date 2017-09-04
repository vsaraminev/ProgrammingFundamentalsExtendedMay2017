using System;
using System.Linq;
using System.Collections.Generic;

namespace OptimizedBankSystem
{
    public class OptimizedBankSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var accountsList = new List<BankAccount>();

            while (input != "end")
            {
                var currentInput = input
                    .Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var currentAcc = new BankAccount()
                {
                    Bank = currentInput[0],
                    Name = currentInput[1],
                    Balance = decimal.Parse(currentInput[2])
                };

                accountsList.Add(currentAcc);

                input = Console.ReadLine();
            }

            accountsList = accountsList
                .OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length)
                .ToList();

            foreach (var account in accountsList)
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }

        public class BankAccount
        {
            public string Name { get; set; }

            public string Bank { get; set; }

            public decimal Balance { get; set; }
        }
    }
}
