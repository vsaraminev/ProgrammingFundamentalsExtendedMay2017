using System;

namespace ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            var temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;

            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
        }
    }
}
