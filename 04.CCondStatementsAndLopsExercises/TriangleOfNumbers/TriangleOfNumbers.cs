using System;

namespace TriangleOfNumbers
{
    public class TriangleOfNumbers
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j <i ; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
