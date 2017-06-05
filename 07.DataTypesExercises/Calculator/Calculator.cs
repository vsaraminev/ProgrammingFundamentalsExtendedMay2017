using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operatorType = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            if (operatorType == "+")
            {
                int result = firstNum + secondNum;

                Console.WriteLine($"{firstNum} {operatorType} {secondNum} = {result}");
            }
            else if (operatorType == "-")
            {
                int result = firstNum - secondNum;

                Console.WriteLine($"{firstNum} {operatorType} {secondNum} = {result}");
            }
            else if (operatorType == "*")
            {
                int result = firstNum * secondNum;

                Console.WriteLine($"{firstNum} {operatorType} {secondNum} = {result}");
            }
            else if (operatorType == "/")
            {
                int result = firstNum / secondNum;

                Console.WriteLine($"{firstNum} {operatorType} {secondNum} = {result}");
            }
        }
    }
}
