using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainlands
{
    public class Trainlands
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var trains = new Dictionary<string, List<WagonInfo>>();

            while (input != "It's Training Men!")
            {
                var currentInput = input
                    .Split(new[] { ' ', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var trainName = currentInput[0];

                if (currentInput.Count > 2)
                {
                    if (currentInput[1] == "=")
                    {
                        var otherTrain = currentInput[2];

                        if (!trains.ContainsKey(trainName))
                        {
                            trains[trainName] = new List<WagonInfo>();
                        }
                        trains[trainName].Clear();
                        trains[trainName].AddRange(trains[otherTrain]);
                    }
                    else
                    {
                        var wagonName = currentInput[1];
                        var wagonPower = int.Parse(currentInput[2]);

                        var currentWagon = new WagonInfo()
                        {
                            Name = wagonName,
                            Power = wagonPower
                        };

                        if (!trains.ContainsKey(trainName))
                        {
                            trains[trainName] = new List<WagonInfo>();
                        }

                        trains[trainName].Add(currentWagon);
                    }
                }
                else
                {
                    var otherTrain = currentInput[1];
                    
                    if (!trains.ContainsKey(trainName))
                    {
                        trains[trainName] = new List<WagonInfo>();
                    }
                    trains[trainName].AddRange(trains[otherTrain]);

                    trains.Remove(otherTrain);
                }

                input = Console.ReadLine();
            }

            foreach (var train in trains.OrderByDescending(x => x.Value.Sum(y => y.Power)).ThenBy(x => x.Value.Count()))
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wagon in train.Value.OrderByDescending(x => x.Power))
                {
                    Console.WriteLine($"###{wagon.Name} - {wagon.Power}");
                }
            }
        }
        public class WagonInfo
        {
            public string Name { get; set; }

            public int Power { get; set; }
        }
    }
}
