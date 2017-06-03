using System;

namespace RectangleArea
{
    public class RectangleArea
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = width * height;

            Console.WriteLine($"{area:f2}");
        }
    }
}
