using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercises
{
    public class Exercises
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var exercisesList = new List<Exercise>();

            while (input != "go go go")
            {
                var currentInput = input
                    .Split(new[] { "->", ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var currentExercise = new Exercise()
                {
                    Topic = currentInput[0],
                    CourseName = currentInput[1],
                    Link = currentInput[2],
                    Problems = currentInput.Skip(3).ToList()
                };

                exercisesList.Add(currentExercise);

                input = Console.ReadLine();
            }

            foreach (var exercise in exercisesList)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{ exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.Link}");

                var count = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }

        public class Exercise
        {
            public string Topic { get; set; }

            public string CourseName { get; set; }

            public string Link { get; set; }

            public List<string> Problems { get; set; }
        }
    }
}
