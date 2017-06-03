using System;

namespace CountTheIntegers
{
    public class CountTheIntegers
    {
        public static void Main()
        {            
            var count = 0;

            try
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine());

                    count++;
                }               
            }
            catch (Exception)
            {
                Console.WriteLine(count);
            }
        }
    }
}
