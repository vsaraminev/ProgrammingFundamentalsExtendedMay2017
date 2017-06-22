using System;
using System.Linq;

namespace ResizableArray
{
    public class ResizableArray
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = new int[4];

            var currentIndex = 0;

            while (input[0] != "end")
            {
                var command = input[0];

                switch (command)
                {
                    case "push":

                        result[currentIndex] = int.Parse(input[1]);
                        currentIndex++;

                        if (currentIndex >= result.Length)
                        {
                            var newArr = new int[result.Length * 2];

                            for (int i = 0; i < currentIndex; i++)
                            {
                                newArr[i] = result[i];
                            }

                            result = newArr;
                        }
                        break;

                    case "pop":

                        result[currentIndex] = 0;
                        currentIndex--;

                        break;

                    case "removeAt":

                        var index = int.Parse(input[1]);
                        GetRemoveAtMethod(result, index, currentIndex);
                        currentIndex--;

                        break;

                    case "clear":

                        currentIndex = 0;

                        break;
                }

                input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            PrintResult(result, currentIndex);
        }

        public static void GetRemoveAtMethod(int[] result, int index, int currentIndex)
        {
            for (int i = index + 1; i < currentIndex; i++)
            {
                result[i - 1] = result[i];
            }
        }

        public static void PrintResult(int[] result, int currentIndex)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }

        public static void GetResizeMethod(int[] result, int currentIndex)
        {
            var newArr = new int[currentIndex * 2];

            for (int i = 0; i < currentIndex; i++)
            {
                newArr[i] = result[i];
            }

            result = newArr;
        }
    }
}
