using System;

namespace DataOverflow
{
    public class DataOverflow
    {
        public static void Main()
        {
            ulong firstNum = ulong.Parse(Console.ReadLine());
            ulong secondNum = ulong.Parse(Console.ReadLine());

            var smallerNum = Math.Min(firstNum, secondNum);
            var greaterNum = Math.Max(firstNum, secondNum);

            var smallerNumType = "";
            var greaterNumType = "";
            var numTypeToDevide = 0.0;

            if (smallerNum <= byte.MaxValue)
            {
                smallerNumType = "byte";
                numTypeToDevide = byte.MaxValue;
            }
            else if (smallerNum <= ushort.MaxValue)
            {
                smallerNumType = "ushort";
                numTypeToDevide = ushort.MaxValue;
            }
            else if (smallerNum <= uint.MaxValue)
            {
                smallerNumType = "uint";
                numTypeToDevide = uint.MaxValue;
            }
            else if (smallerNum <= ulong.MaxValue)
            {
                smallerNumType = "ulong";
                numTypeToDevide = ulong.MaxValue;
            }

            if (greaterNum <= byte.MaxValue)
            {
                greaterNumType = "byte";
            }
            else if (greaterNum <= ushort.MaxValue)
            {
                greaterNumType = "ushort";
            }
            else if (greaterNum <= uint.MaxValue)
            {
                greaterNumType = "uint";
            }
            else if (greaterNum <= ulong.MaxValue)
            {
                greaterNumType = "ulong";
            }

            var overFlow = Math.Round(greaterNum / numTypeToDevide);

            Console.WriteLine($"bigger type: {greaterNumType}");
            Console.WriteLine($"smaller type: {smallerNumType}");
            Console.WriteLine($"{greaterNum} can overflow {smallerNumType} {overFlow} times");
        }
    }
}
