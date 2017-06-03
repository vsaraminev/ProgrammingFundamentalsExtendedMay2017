using System;

namespace BeverageLabels
{
    public class BeverageLabels
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarContent = double.Parse(Console.ReadLine());

            var energyResult = volume * energyContent / 100;
            var sugarResult = volume * sugarContent / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyResult}kcal, {sugarResult}g sugars");
        }
    }
}
