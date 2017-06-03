using System;

namespace MagicLetter
{
    public class MagicLetter
    {
        public static void Main()
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            var magicCahr = char.Parse(Console.ReadLine());

            for (char i = firstChar; i <= secondChar; i++)
            {
                if (i != magicCahr)
                {
                    for (char j = firstChar; j <= secondChar; j++)
                    {
                        if (j != magicCahr)
                        {
                            for (char k = firstChar; k <= secondChar; k++)
                            {
                                if (k != magicCahr)
                                {
                                    Console.Write($"{i}{j}{k} ");
                                }
                            }
                        }

                    }
                }

            }
        }
    }
}
