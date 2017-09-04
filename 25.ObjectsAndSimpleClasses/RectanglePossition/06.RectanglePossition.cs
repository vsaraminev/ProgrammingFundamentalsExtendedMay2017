using System;
using System.Linq;

namespace RectanglePossition
{
    class RectanglePossition
    {
        static void Main(string[] args)
        {
            var firstRectInput = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();
            var firstRec = new Rectangle()
            {
                Left = firstRectInput[0],
                Top = firstRectInput[1],
                Width = firstRectInput[2],
                Height = firstRectInput[3]
            };

            var secondRecInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondRec = new Rectangle()
            {
                Left = secondRecInput[0],
                Top = secondRecInput[1],
                Width = secondRecInput[2],
                Height = secondRecInput[3]
            };

            var isLeftIns = firstRec.Left >= secondRec.Left;
            var isRightIns = firstRec.Right <= secondRec.Right;
            var isTopIns = firstRec.Top <= secondRec.Top;
            var isBottomIns = firstRec.Bottom >= secondRec.Bottom;

            if (isLeftIns && isRightIns && isTopIns && isBottomIns)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public class Rectangle
        {
            public int Left { get; set; }

            public int Top { get; set; }

            public int Width { get; set; }

            public int Height { get; set; }

            public int Bottom
            {
                get
                {
                    return Top - Width;
                }
            }

            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }
        }
    }
}
