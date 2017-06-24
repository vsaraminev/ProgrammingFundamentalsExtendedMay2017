using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackDownloader
{
    public class TrackDownloader
    {
        public static void Main()
        {
            var blackList = Console.ReadLine()
                .Split(' ')
                .ToList();

            var fileName = Console.ReadLine();

            var result = new List<string>();

            while (fileName != "end")
            {
                bool isFound = false;

                foreach (var word in blackList)
                {
                    if (fileName.Contains(word))
                    {
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    result.Add(fileName);
                }

                fileName = Console.ReadLine();
            }

            result.Sort();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
               
        }
    }
}
