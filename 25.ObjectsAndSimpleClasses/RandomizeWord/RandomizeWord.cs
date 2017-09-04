using System;
using System.Linq;

namespace RandomizeWord
{
   public class RandomizeWord
    {
       public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var currentWord = input[i];
                var randomIndex = random.Next(input.Length);
                
                var temp = input[randomIndex];
                input[randomIndex] = currentWord;
                input[i] = temp;
            }

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
