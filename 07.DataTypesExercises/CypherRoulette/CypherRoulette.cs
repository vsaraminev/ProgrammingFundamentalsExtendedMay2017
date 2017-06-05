using System;

namespace CypherRoulette
{
    public class CypherRoulette
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string text = "";

            var previousString = "";

            bool isEndAdd = true;

            for (int i = 0; i < n; i++)
            {
                var currentString = Console.ReadLine();                              

                if (currentString == "spin")
                {
                    isEndAdd = !isEndAdd;
                    i--;
                }
                else if (isEndAdd)
                {
                    text += currentString;
                }
                else if (!isEndAdd)
                {
                    text = currentString + text;
                }

                if (currentString == previousString)
                {
                    text = string.Empty;

                    if (currentString == "spin")
                    {
                        isEndAdd = !isEndAdd;
                    }
                }

                previousString = currentString;

            }

            Console.WriteLine(text);
                         
        }
    }
}
