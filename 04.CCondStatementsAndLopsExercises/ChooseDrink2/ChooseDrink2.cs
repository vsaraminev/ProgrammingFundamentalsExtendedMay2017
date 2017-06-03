using System;
namespace ChooseDrink2
{
    public class ChooseDrink2
    {
        public static void Main()
        {
            var proffesion = Console.ReadLine();

            var quantity = int.Parse(Console.ReadLine());

            var price = 0.0;
            
            if (proffesion == "Athlete")
            {
                price = 0.7;
            }
            else if (proffesion == "Businessman" || proffesion == "Businesswoman")
            {
                price = 1.00;
            }
            else if (proffesion == "SoftUni Student")
            {
                price = 1.70;
            }
            else
            {
                price = 1.20;
            }

            var total = quantity * price;

            Console.WriteLine($"The {proffesion} has to pay {total:f2}.");
        }
    }
}
