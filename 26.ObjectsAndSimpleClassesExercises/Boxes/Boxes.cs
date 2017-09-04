using System;
using System.Linq;
using System.Collections.Generic;

namespace Boxes
{
    public class Boxes
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var boxesList = new List<Box>();

            while (input != "end")
            {
                var currentInput = input
                    .Split(new[] { ' ', ':', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var currentBox = new Box()
                {
                    UpperLeft = ReadPoint(int.Parse((string)currentInput[0]), int.Parse((string)currentInput[1])),
                    UpperRight = ReadPoint(int.Parse((string)currentInput[2]), int.Parse((string)currentInput[3])),
                    BottomLeft = ReadPoint(int.Parse((string)currentInput[4]), int.Parse((string)currentInput[5])),
                    BottomRight = ReadPoint(int.Parse((string)currentInput[6]), int.Parse((string)currentInput[7]))
                };

                boxesList.Add(currentBox);

                input = Console.ReadLine();
            }

            foreach (var box in boxesList)
            {
                var width = Point.CalculateDistance(box.UpperLeft, box.UpperRight);
                var height = Point.CalculateDistance(box.UpperLeft, box.BottomLeft);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter((int)width, (int)height)}");
                Console.WriteLine($"Area: {Box.CalculateArea((int)width, (int)height)}");
            }
        }

        private static Point ReadPoint(int x1, int x2)
        {
            var point = new Point
            {
                X = x1,
                Y = x2
            };
            return point;
        }

        public class Point
        {
            public int X { get; set; }

            public int Y { get; set; }

            public static double CalculateDistance(Point firstPoint, Point secondPoint)
            {
                var sideX = Math.Abs(firstPoint.X - secondPoint.X);
                var sideY = Math.Abs(firstPoint.Y - secondPoint.Y);

                return Math.Sqrt(Math.Pow((sideX), 2) + Math.Pow((sideY), 2));
            }
        }

        public class Box
        {
            public Point UpperLeft { get; set; }

            public Point UpperRight { get; set; }

            public Point BottomLeft { get; set; }

            public Point BottomRight { get; set; }

            public static int CalculatePerimeter(int widht, int height)
            {
                return ((2 * widht) + (2 * height));
            }
            public static int CalculateArea(int widht, int height)
            {
                return (widht * height);
            }
        }
    }
}

