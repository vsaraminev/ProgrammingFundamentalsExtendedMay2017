using System;

namespace WordInPlural
{
    public class WordInPlural
    {
        public static void Main()
        {
            var noun = Console.ReadLine();

            var result = "";

            if (noun.EndsWith("y"))
            {
                result = noun.Remove(noun.Length - 1);
                Console.WriteLine(result + "ies");
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s")
                                        || noun.EndsWith("x") || noun.EndsWith("z") || noun.EndsWith("sh"))
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }
        }
    }
}
