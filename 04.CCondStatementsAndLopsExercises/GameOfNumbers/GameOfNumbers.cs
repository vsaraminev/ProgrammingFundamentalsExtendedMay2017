using System;

namespace GameOfNumbers
{
    public class GameOfNumbers
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var magicI = 0;
            var magicJ = 0;
            var count = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    count++;

                    if (i + j == magicNum)
                    {
                        magicI = i;
                        magicJ = j;
                    }
                }
            }

            if (magicI > 0)
            {
                Console.WriteLine($"Number found! {magicI} + {magicJ} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
