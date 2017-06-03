using System;

namespace CaloriesCounter
{
    public class CaloriesCounter
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var counter = 0;
            
            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    counter += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    counter += 150;
                }
                else if (ingredient == "salami")
                {
                    counter += 600;
                }
                else if (ingredient == "pepper")
                {
                    counter += 50;
                }
            }

            Console.WriteLine($"Total calories: {counter}");
        }
    }
}
