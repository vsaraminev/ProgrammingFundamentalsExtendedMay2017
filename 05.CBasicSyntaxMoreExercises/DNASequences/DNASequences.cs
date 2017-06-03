using System;

namespace DNASequences
{
    public class DNASequences
    {
        public static void Main()
        {
            var matchSum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        var result = $"{i}{j}{k}";

                        result = result.Replace("1", "A").Replace("2", "C").Replace("3", "G").Replace("4", "T");

                        if (i + j + k >= matchSum)
                        {
                            Console.Write($"O{result}O ");
                        }
                        else
                        {
                            Console.Write($"X{result}X ");
                        }

                        if (k == 4)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
