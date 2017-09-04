using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamShopping
{
    public class ExamShopping
    {
        public static void Main()
        {
            var input = Console.ReadLine()
               .Split(' ')
               .ToList();

            var inventory = new Dictionary<string, int>();

            while (input[0] != "shopping")
            {
                if (inventory.ContainsKey(input[1]))
                {
                    inventory[input[1]] += int.Parse(input[2]);
                }
                else
                {
                    inventory[input[1]] = int.Parse(input[2]);
                }

                input = Console.ReadLine()
                .Split(' ')
                .ToList();
            }

            while (input[0] != "exam")
            {
                if (!inventory.ContainsKey(input[1]) && input[0] != "shopping")
                {
                    Console.WriteLine($"{input[1]} doesn't exist");
                }
                else if (inventory.ContainsKey(input[1]))
                {
                    if (inventory[input[1]] == 0)
                    {
                        Console.WriteLine($"{input[1]} out of stock");
                    }
                    else if (int.Parse(input[2]) >= inventory[input[1]])
                    {
                        inventory[input[1]] = 0;
                    }
                    else if (int.Parse(input[2]) < inventory[input[1]])
                    {
                        inventory[input[1]] -= int.Parse(input[2]);
                    }
                }

                input = Console.ReadLine()
                .Split(' ')
                .ToList();
            }

            foreach (var item in inventory)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
