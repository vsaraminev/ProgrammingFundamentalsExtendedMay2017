using System;

namespace DebitCardNumber
{
    public class DebitCardNumber
    {
        public static void Main()
        {
            var fitstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var fourthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{fitstNum:d4} {secondNum:d4} {thirdNum:d4} {fourthNum:d4}");
        }
    }
}