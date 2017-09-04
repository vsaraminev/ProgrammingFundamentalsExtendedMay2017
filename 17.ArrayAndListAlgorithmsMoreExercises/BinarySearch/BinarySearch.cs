using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    public class BinarySearch
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var number = int.Parse(Console.ReadLine());

            if (numbersList.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            var linearCount = GetLinearMethod(numbersList, number);

            var binaryCount = GetBinaryMethod(numbersList, number);

            Console.WriteLine($"Linear search made {linearCount} iterations");

            Console.WriteLine($"Binary search made {binaryCount} iterations");

        }

        public static int GetLinearMethod(List<int> numbersList, int number)
        {
            var count = 0;

            for (int i = 0; i < numbersList.Count; i++)
            {
                count++;

                if (numbersList[i] == number)
                {
                    break;
                }
            }

            return count;
        }

        public static int GetBinaryMethod(List<int> numbersList, int number)
        {
            var count = 0;

            numbersList.Sort();
            
            var min = 0;
            var max = numbersList.Count-1;

            while (min <= max)
            {
                count++;

                var midPoint = (max + min) / 2;                

                if (numbersList[midPoint] < number)
                {
                    min = midPoint + 1;
                }

                if (numbersList[midPoint] > number)
                {
                    max = midPoint - 1;
                }

                if (numbersList[midPoint] == number)
                {
                    break;
                }                
            }

            return count;
        }
    }
}
