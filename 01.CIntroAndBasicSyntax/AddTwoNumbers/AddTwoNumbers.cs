using System;

namespace AddTwoNumbers
{
    public class AddTwoNumbers
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var result = firstNum + secondNum;

            Console.WriteLine($"{firstNum} + {secondNum} = {result} ");
        }
    }
}
