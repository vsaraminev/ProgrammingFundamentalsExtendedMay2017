using System;

namespace PhotoGallery
{
    public class PhotoGallery
    {
        public static void Main()
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSize = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var orientation = "";
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            var resultSize = 0.0;
            var dimension = "";

            if (photoSize < 1000)
            {
                resultSize = photoSize;
                dimension = "B";
            }
            else if (photoSize < 1000000)
            {
                resultSize = photoSize / 1000;
                dimension = "KB";
            }
            else
            {
                resultSize = photoSize / 1000000;
                dimension = "MB";
            }

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            Console.WriteLine($"Size: {resultSize}{dimension}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
