using System;
using System.Linq;

namespace DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPoint = ReadPoint();

            var secondPoint = ReadPoint();

            var result = Distance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }

        private static double Distance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow((firstPoint.X - secondPoint.X), 2);
            var squareY = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            var distance = Math.Sqrt(squareX + squareY);

            return distance;
        }

        public static Point ReadPoint()
        {
            var cordinates = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            return new Point
            {
                X = cordinates[0],
                Y = cordinates[1]

            };
        }
    }
}
