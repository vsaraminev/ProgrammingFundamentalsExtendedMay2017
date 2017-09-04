using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    public class RecordUniqueNames
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var nameSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var currnetName = Console.ReadLine();

                nameSet.Add(currnetName);
            }

            foreach (var name in nameSet)
            {
                Console.WriteLine(name);
            }
        }
    }
}
