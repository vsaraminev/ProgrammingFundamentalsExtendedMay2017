using System;

namespace MultiTable
{
    public class MultiTable
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());            
            
            for (int i = 1; i <= 10; i++)
            {
                var result = number * i;
                Console.WriteLine($"{number} X {i} = {result}");
            }
        }
    }
}
