using System;

namespace RectanglePossition
{
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
