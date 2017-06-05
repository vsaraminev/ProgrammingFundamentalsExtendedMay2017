using System;

namespace VariableInHexadecimalFormat
{
    public class VariableInHexadecimalFormat
    {
        public static void Main()
        {
            string number = Console.ReadLine();

            decimal result = Convert.ToInt32(number, 16);

            Console.WriteLine(result);
        }
    }
}
