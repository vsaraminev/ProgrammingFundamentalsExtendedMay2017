using System;

namespace IntervalOfNumbers
{
    public class IntervalOfNumbers
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            for (int i = Math.Min(firstNum,secondNum); i <= Math.Max(firstNum,secondNum); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
