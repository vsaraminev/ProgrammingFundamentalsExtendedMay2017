using System;

namespace SpecialNumber
{
    public class SpecialNumber
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                var sum = 0;

                int currentNum = i;

                bool isSpecial = false;                

                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                }

                if (sum == 5 || sum == 7 || sum ==11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
