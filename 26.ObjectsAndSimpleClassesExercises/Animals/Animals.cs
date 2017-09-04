using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class Animals
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            while (input != "I'm your Huckleberry")
            {
                var currentInput = input
                    .Split(' ')
                    .ToList();
                if (currentInput.Count> 2)
                {
                    var clas = currentInput[0];
                    var name = currentInput[1];
                    var age = int.Parse(currentInput[2]);
                    var parameter = int.Parse(currentInput[3]);

                    switch (clas)
                    {
                        case "Dog":
                            var CurrentDog = new Dog()
                            {
                                Name = name,
                                Age = age,
                                NumberOfLegs = parameter
                            };

                            dogs.Add(CurrentDog.Name, CurrentDog);
                            break;

                        case "Cat":
                            var currentCat = new Cat()
                            {
                                Name = name,
                                Age = age,
                                IntelligenceQuotient = parameter
                            };

                            cats.Add(currentCat.Name, currentCat);
                            break;

                        case "Snake":
                            var currentSnake = new Snake()
                            {
                                Name = name,
                                Age = age,
                                CrueltyCoefficient = parameter
                            };

                            snakes.Add(currentSnake.Name, currentSnake);
                            break;
                    }
                }
                else
                {
                    var givenName = currentInput[1];

                    if (dogs.ContainsKey(givenName))
                    {
                        dogs[givenName].ProduceSound();
                    }
                    else if (cats.ContainsKey(givenName))
                    {
                        cats[givenName].ProduceSound();
                    }
                    else if (snakes.ContainsKey(givenName))
                    {
                        snakes[givenName].ProduceSound();
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        public class Dog
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public int NumberOfLegs { get; set; }

            public void ProduceSound()
            {
                Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            }
        }

        public class Cat
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public int IntelligenceQuotient { get; set; }

            public void ProduceSound()
            {
                Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            }
        }

        public class Snake
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public int CrueltyCoefficient { get; set; }

            public void ProduceSound()
            {
                Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            }
        }
    }
}
