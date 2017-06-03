using System;

namespace TestNumbers
{
    public class TestNumbers
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var stopNum = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var count = 0;

            bool isStopNum = false;

            for (int i = firstNum; i > 0; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    count++;

                    sum += 3 * i * j;

                    if (sum >= stopNum)
                    {
                        isStopNum = true;
                        break;
                    }
                }

                if (isStopNum)
                {
                    Console.WriteLine($"{count} combinations");
                    Console.WriteLine($"Sum: {sum} >= {stopNum}");
                    break;
                }
            }

            if (sum < stopNum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
