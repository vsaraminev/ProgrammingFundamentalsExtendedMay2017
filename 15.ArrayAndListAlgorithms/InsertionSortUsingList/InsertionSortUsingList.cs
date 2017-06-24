using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertionSortUsingList
{
    class InsertionSortUsingList
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var resultList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var inserted = false;

                var currentElement = numbers[i];

                for (int j = 0; j < resultList.Count; j++)
                {
                    var currentListElement = resultList[j];

                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        resultList.Insert(Math.Max(0, j), currentElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    resultList.Add(currentElement);
                }
            }

            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
