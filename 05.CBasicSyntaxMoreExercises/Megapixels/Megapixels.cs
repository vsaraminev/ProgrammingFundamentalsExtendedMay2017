using System;

namespace Megapixels
{
    public class Megapixels
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            double megapixels = Math.Round(((width * height) / 1000000), 1);
            
            Console.WriteLine($"{width}x{height} => {megapixels}MP");
        }
    }
}
