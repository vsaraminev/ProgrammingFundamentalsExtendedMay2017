using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniBeerPong
{
    public class SoftUniBeerPong
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var teams = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "stop the game")
            {
                var player = input[0];
                var team = input[1];
                var points = int.Parse(input[2]);

                if (!teams.ContainsKey(team))
                {
                    teams[team] = new Dictionary<string, int>();
                }

                if (teams[team].Values.Count < 3)
                {
                    teams[team][player] = points;
                }

                input = Console.ReadLine()
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            var count = 1;
            
            foreach (var team in teams.Where(x => x.Value.Count > 2).OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{count}. {team.Key}; Players:");

                foreach (var item in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{item.Key}: {item.Value}");
                }

                count++;
            }
        }
    }
}
