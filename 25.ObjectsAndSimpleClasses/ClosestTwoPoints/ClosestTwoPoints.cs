using System;
using System.Linq;
using System.Collections.Generic;

namespace ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var pointsList = new List<Point>();

            var minDistance = double.MaxValue;

            Point firstPoint = null;
            Point secondPoint = null;

            for (int i = 0; i < n; i++)
            {
                var currentInput = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                var currentPoint = new Point();
                currentPoint.X = int.Parse(currentInput[0]);
                currentPoint.Y = int.Parse(currentInput[1]);

                pointsList.Add(currentPoint);
            }

            for (int first = 0; first < pointsList.Count; first++)
            {
                for (int second = first + 1; second < pointsList.Count; second++)
                {
                    var firstP = pointsList[first];
                    var secondP = pointsList[second];

                    var distance = Distance(firstP, secondP);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPoint = firstP;
                        secondPoint = secondP;
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
            Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");
        }

        private static double Distance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow((firstPoint.X - secondPoint.X), 2);
            var squareY = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            var distance = Math.Sqrt(squareX + squareY);

            return distance;
        }
        
        public class Point
        {
            public int X { get; set; }

            public int Y { get; set; }
        }
    }
}
