using System;

namespace VaporStore
{
    public class VaporStore
    {
        public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());

            var gameName = Console.ReadLine();

            var restMoney = budget;

            while (gameName != "Game Time")
            {
                var game = "";
                var gamePrice = 0.0;
                bool isOutOfMoney = false;

                switch (gameName)
                {
                    case "OutFall 4":
                        game = "OutFall 4";
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        game = "CS: OG";
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        game = "Zplinter Zell";
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        game = "Honored 2";
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        game = "RoverWatch";
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        game = "RoverWatch Origins Edition";
                        gamePrice = 39.99;
                        break;

                    default:
                        game = "Not Found";
                        break;
                }

                if (game != "Not Found")
                {
                    if (restMoney > 0)
                    {
                        if (restMoney >= gamePrice)
                        {
                            restMoney -= gamePrice;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (restMoney < gamePrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Out of money!");
                        isOutOfMoney = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (isOutOfMoney)
                {
                    break;
                }

                gameName = Console.ReadLine();
            }

            if (restMoney <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${(budget - restMoney):f2}. Remaining: ${restMoney:f2}");
            }
        }
    }
}