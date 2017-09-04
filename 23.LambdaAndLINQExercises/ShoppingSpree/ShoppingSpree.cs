using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class ShoppingSpree
    {
        public static void Main()
        {
            var budget = decimal.Parse(Console.ReadLine());

            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var products = new Dictionary<string, decimal>();

            while (input[0] != "end")
            {
                var product = input[0];
                var price = decimal.Parse(input[1]);

                if (!products.ContainsKey(product))
                {
                    products[product] = price;
                }
                else
                {
                    if (products[product] > price)
                    {
                        products[product] = price;
                    }
                }

                input = Console.ReadLine()
                .Split(' ')
                .ToList();
            }

            var sum = products.Values.Sum();

            if (sum > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (var product in products.OrderByDescending(x => x.Value).ThenBy(x=>x.Key.Length))
                {
                    Console.WriteLine($"{product.Key} costs {product.Value:f2}");
                }
            }
        }
    }
}
