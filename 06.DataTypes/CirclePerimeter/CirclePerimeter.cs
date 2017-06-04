using System;

namespace CirclePerimeter
{
    public class CirclePerimeter
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = 2 * Math.PI * radius;

            Console.WriteLine($"{area:f12}");
        }
    }
}
