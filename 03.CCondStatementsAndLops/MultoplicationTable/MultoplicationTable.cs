using System;

namespace MultoplicationTable
{
    public class MultoplicationTable
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    var result = number * i;
                    Console.WriteLine($"{number} X {i} = {result}");
                }
            }
            else
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            }

        }
    }
}
