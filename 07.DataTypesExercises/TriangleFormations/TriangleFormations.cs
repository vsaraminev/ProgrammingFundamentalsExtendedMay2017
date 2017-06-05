using System;

namespace TriangleFormations
{
  public  class TriangleFormations
    {
       public static void Main()
        {
            int firstSide = int.Parse(Console.ReadLine());
            int secondSide = int.Parse(Console.ReadLine());
            int thirdSide = int.Parse(Console.ReadLine());

            if (firstSide+secondSide > thirdSide && firstSide+thirdSide > secondSide && secondSide+thirdSide > firstSide)
            {
                Console.WriteLine("Triangle is valid.");

                if (Math.Pow(firstSide,2) + Math.Pow(secondSide,2)==Math.Pow(thirdSide,2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
