using System;

namespace Hotel
{
    public class Hotel
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var priceStudio = 0.0;
            var priceDouble = 0.0;
            var priceSuite = 0.0;

            var freeNight = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceDouble = 65;
                priceSuite = 75;

                if (nights > 7)
                {
                    priceStudio *= 0.95;

                    if (month == "October")
                    {
                        freeNight = 1;
                    }
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 60;
                priceDouble = 72;
                priceSuite = 82;

                if (nights > 7 && month == "September")
                {
                    freeNight = 1;
                }

                if (nights > 14)
                {
                    priceDouble *= 0.9;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = 89;

                if (nights > 14)
                {
                    priceSuite *= 0.85;
                }
            }

            var totalStudio = priceStudio * (nights - freeNight);
            var totalDouble = priceDouble * nights;
            var totalSuite = priceSuite * nights;

            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
            Console.WriteLine($"Double: {totalDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalSuite:f2} lv.");
        }
    }
}
