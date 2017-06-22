using System;
using System.Linq;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var names = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var line = Console.ReadLine();

            while (line != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (line == names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                } 

                line = Console.ReadLine();

            }
        }
    }
}
