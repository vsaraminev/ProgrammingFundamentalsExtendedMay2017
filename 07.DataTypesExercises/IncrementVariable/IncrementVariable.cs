using System;
namespace IncrementVariable
{
    public class IncrementVariable
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int count = 0;

            if (number >= 256)
            {
                while (number >= 256)
                {
                    count++;
                    number -= 256;
                }
            }

            Console.WriteLine(number);

            if (count != 0)
            {
                Console.WriteLine($"Overflowed {count} times");
            }
        }
    }
}
