using System;

namespace RestorantDiscount
{
    public class RestorantDiscount
    {
        public static void Main()
        {
            var people = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var priceHall = 0.0;
            var hall = "";

            if (people > 0 && people <= 50)
            {
                priceHall = 2500;
                hall = "Small Hall";
            }
            else if (people <= 100)
            {
                priceHall = 5000;
                hall = "Terrace";
            }
            else if (people <= 120)
            {
                priceHall = 7500;
                hall = "Great Hall";
            }

            var pricePackage = 0.0;
            var discount = 0.0;

            switch (package)
            {
                case "Normal":
                    pricePackage = 500;
                    discount = 0.05;
                    break;
                case "Gold":
                    pricePackage = 750;
                    discount = 0.1;
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    discount = 0.15;
                    break;
            }

            var total = priceHall + pricePackage;

            var pricePerPerson = (total - (total * discount))/people;

            if (priceHall == 0)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }           
        }
    }
}
