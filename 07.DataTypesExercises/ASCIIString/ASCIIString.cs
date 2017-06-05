using System;

namespace ASCIIString
{
    public class ASCIIString
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string text = "";

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                char character = (char)currentNum;

                text += character;
            }

            Console.WriteLine(text);
        }
    }
}
