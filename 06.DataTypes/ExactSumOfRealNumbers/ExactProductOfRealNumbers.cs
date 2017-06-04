using System;

namespace ExactProductOfRealNumbers
{
    public class ExactProductOfRealNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 1;

            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum *= number;
            }

            Console.WriteLine(sum);
        }
    }
}
