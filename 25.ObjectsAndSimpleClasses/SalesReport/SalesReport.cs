using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentInput = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                var currentSale = new Sale()
                {
                    Town = currentInput[0],
                    Product = currentInput[1],
                    Price = decimal.Parse(currentInput[2]),
                    Quantity = decimal.Parse(currentInput[3])
                };

                if (!dictionary.ContainsKey(currentSale.Town))
                {
                    dictionary[currentSale.Town] = 0;
                }

                dictionary[currentSale.Town] += currentSale.Total;
            }

            dictionary = dictionary.OrderBy(t => t.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var town in dictionary)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }

        public class Sale
        {
            public string Town { get; set; }

            public string Product { get; set; }

            public decimal Price { get; set; }

            public decimal Quantity { get; set; }

            public decimal Total
            {
                get
                {
                    return Quantity * Price;
                }
            }
        }
    }
}
