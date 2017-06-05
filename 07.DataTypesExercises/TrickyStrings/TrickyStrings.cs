using System;

namespace TrickyStrings
{
    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string text = "";

            for (int i = 0; i < n; i++)
            {
                string curretntString = Console.ReadLine();

                if (i == 0)
                {
                    text += $"{curretntString}";
                }
                else
                {
                    text += $"{delimiter}{curretntString}";
                }
            }

            Console.WriteLine(text);
        }
    }
}
