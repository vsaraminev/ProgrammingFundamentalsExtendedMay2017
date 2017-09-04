using System;
using System.Collections.Generic;

namespace FilterBase
{
    public class FilterBase
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var ageDictionary = new Dictionary<string, int>();
            var salaryDictionary = new Dictionary<string, double>();
            var positionDictionary = new Dictionary<string, string>();

            var ageNumber = 0;
            var salaryNumber = 0.0;

            while (input[0] != "filter")
            {
                if (int.TryParse(input[1], out ageNumber))
                {
                    ageDictionary[input[0]] = ageNumber;
                }
                else if (double.TryParse(input[1], out salaryNumber))
                {
                    salaryDictionary[input[0]] = salaryNumber;
                }
                else
                {
                    positionDictionary[input[0]] = input[1];
                }

                input = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var command = input[0];

            switch (command)
            {
                case "Age":
                    foreach (var item in ageDictionary)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Age: {item.Value}");
                        Console.WriteLine("====================");
                    }
                    break;

                case "Salary":
                    foreach (var item in salaryDictionary)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Salary: {item.Value:f2}");
                        Console.WriteLine("====================");
                    }
                    break;

                case "Position":
                    foreach (var item in positionDictionary)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Position: {item.Value}");
                        Console.WriteLine("====================");
                    }
                    break;
            }
        }
    }
}
