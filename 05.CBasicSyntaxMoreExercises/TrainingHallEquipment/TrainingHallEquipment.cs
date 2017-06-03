using System;

namespace TrainingHallEquipment
{
   public class TrainingHallEquipment
    {
       public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var numberItems = int.Parse(Console.ReadLine());

            var total = 0.0;

            for (int i = 0; i < numberItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                var pluralize = string.Empty;

                if (itemCount > 1)
                {
                    pluralize = "s";
                }

                total += itemPrice * itemCount;

                Console.WriteLine($"Adding {itemCount} {itemName}{pluralize} to cart.");
            }

            Console.WriteLine($"Subtotal: ${total:f2}");

            if (total > budget)
            {
                Console.WriteLine($"Not enough. We need ${(total - budget):f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${(budget - total):f2}");
            }
        }
    }
}
