using System;

namespace TriplesOfLatinLetters
{
    public class TriplesOfLatinLetters
    {
        private static int i;

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (char firstChar = 'a'; firstChar < 'a'+number; firstChar++)
            {
                for (char secondChar = 'a'; secondChar < 'a' + number; secondChar++)
                {
                    for (char thirdChar = 'a'; thirdChar < 'a'+number; thirdChar++)
                    {
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }

                }
            }
        }
    }
}
