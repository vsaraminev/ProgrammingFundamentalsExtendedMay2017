using System;

namespace ChooseADrink
{
    public class ChooseADrink
    {
        public static void Main()
        {
            var proffesion = Console.ReadLine();

            if (proffesion == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (proffesion == "Businessman" || proffesion == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (proffesion == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
