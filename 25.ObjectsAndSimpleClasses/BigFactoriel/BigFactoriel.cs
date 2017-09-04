using System;
using System.Numerics;

namespace BigFactoriel
{
    public class BigFactoriel
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;

            for (int i = number; i > 1; i--)
            {
                factoriel *= i;
            }

            Console.WriteLine(factoriel);
        }
    }
}
