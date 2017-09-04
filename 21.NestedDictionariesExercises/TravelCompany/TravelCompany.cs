using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelCompany
{
    public class TravelCompany
    {
        public static void Main()
        {
            var line = Console.ReadLine()
                .Split(new[] { ':', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var dictionary = new Dictionary<string, Dictionary<string, int>>();

            while (line[0] != "ready")
            {
                var town = line[0];

                for (int i = 1; i < line.Count; i++)
                {
                    var currentTransport = line[i].Split('-');

                    var vehicle = currentTransport[0];
                    var capacity = int.Parse(currentTransport[1]);

                    if (!dictionary.ContainsKey(town))
                    {
                        dictionary[town] = new Dictionary<string, int>();
                    }

                    if (!dictionary[town].ContainsKey(vehicle))
                    {
                        dictionary[town][vehicle] = 0;
                    }

                    dictionary[town][vehicle] = capacity;
                }


                line = Console.ReadLine()
                .Split(new[] { ':', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            var groups = Console.ReadLine().Split(' ');

            while (groups[0] != "travel")
            {
                var groupTwon = groups[0];
                var groupCapacity = int.Parse(groups[1]);

                foreach (var item in dictionary)
                {
                    if (item.Key.Contains(groupTwon))
                    {
                        if (item.Value.Values.Sum()>=groupCapacity)
                        {
                            Console.WriteLine($"{item.Key} -> all {groupCapacity} accommodated");
                        }
                        else
                        {
                            Console.WriteLine($"{item.Key} -> all except {groupCapacity- item.Value.Values.Sum()} accommodated");
                        }
                    }

                }


                groups = Console.ReadLine().Split(' ');
            }
        }
    }
}
