using System;
using System.Collections.Generic;
using System.Linq;

namespace MostValuedCustomer
{
    public class MostValuedCustomer
    {
        public static void Main()
        {

            var input = Console.ReadLine();

            var products = new Dictionary<string, decimal>();

            while (input != "Shop is open")
            {
                var currentLine = input.Split(' ').ToList();

                var product = currentLine[0];
                var value = decimal.Parse(currentLine[1]);

                if (!products.ContainsKey(product))
                {
                    products[product] = 0;
                }

                products[product] = value;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var customersDict = new Dictionary<string, List<string>>();

            while (input != "Print")
            {
                var currentLine = input.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (currentLine[0] == "Discount")
                {
                    var DiscProducts = products
                        .OrderByDescending(x => x.Value)
                        .Take(3)
                        .ToDictionary(x => x.Key, x => x.Value * 0.9M);

                    var restProduct = products
                        .OrderByDescending(x => x.Value)
                        .Skip(3)
                        .ToDictionary(x => x.Key, x => x.Value);

                    products = DiscProducts
                        .Concat(restProduct)
                        .GroupBy(x => x.Key)
                        .ToDictionary(x => x.Key, x => x.First().Value);

                }
                else
                {
                    var customerName = currentLine[0];
                    var customerProducts = currentLine[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (!customersDict.ContainsKey(customerName))
                    {
                        customersDict[customerName] = new List<string>();
                    }

                    foreach (var item in customerProducts)
                    {
                        if (products.ContainsKey(item))
                        {
                            customersDict[customerName].Add(item);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var spendsCustomer = new Dictionary<string, decimal>();

            foreach (var customer in customersDict)
            {
                var currentCustomer = customer.Key;
                var currentProducts = customer.Value;

                if (!spendsCustomer.ContainsKey(currentCustomer))
                {
                    spendsCustomer[currentCustomer] = 0;
                }

                foreach (var product in currentProducts)
                {
                    spendsCustomer[currentCustomer] += products[product];
                }
            }

            var mostSpendCustomer = spendsCustomer
                .OrderByDescending(x => x.Value)
                .First()
                .Key;

            var mostCustProducts = customersDict[mostSpendCustomer]
                .Distinct()
                .ToList();

            Console.WriteLine($"Biggest spender: {mostSpendCustomer}");
            Console.WriteLine("^Products bought:");

            var finalProducts = new Dictionary<string, decimal>();

            foreach (var product in mostCustProducts)
            {
                foreach (var item in products.OrderByDescending(x => x.Value))
                {
                    if (item.Key == product)
                    {
                        finalProducts.Add(product, item.Value);
                    }
                }
            }

            foreach (var prod in finalProducts.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"^^^{prod.Key}: {prod.Value:f2}");
            }

            Console.WriteLine($"Total: {spendsCustomer[mostSpendCustomer]:f2}");
        }
    }
}
