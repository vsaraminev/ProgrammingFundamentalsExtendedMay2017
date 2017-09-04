using System;
using System.Linq;

namespace RabbitHole
{
    public class RabbitHole
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var totalEnergy = int.Parse(Console.ReadLine());

            var index = 0;

            bool isBomb = false;

            while (true)
            {
                var line = input[index].Split('|').ToArray();

                var command = line[0];

                switch (command)
                {
                    case "Right":
                        index = (index + int.Parse(line[1])) % input.Count;
                        totalEnergy -= int.Parse(line[1]);
                        break;

                    case "Left":
                        index = (Math.Abs(index - int.Parse(line[1]))) % input.Count;
                        totalEnergy -= int.Parse(line[1]);
                        break;

                    case "Bomb":
                        totalEnergy -= int.Parse(line[1]);
                        input.RemoveAt(index);
                        index = 0;
                        isBomb = true;
                        break;

                    case "RabbitHole":
                        Console.WriteLine("You have 5 years to save Kennedy!");
                        return;
                }

                if (totalEnergy <= 0)
                {
                    if (isBomb)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        break;
                    }
                }

                if (input[input.Count-1] != "RabbitHole")
                {
                    input.Remove(input[input.Count - 1]);
                }
                input.Add($"Bomb|{totalEnergy}");
            }
        }
    }
}
