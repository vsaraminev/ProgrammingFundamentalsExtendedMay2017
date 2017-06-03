using System;

namespace _5DifferentNumbers
{
    public class _5DifferentNumbers
    {
        public static void Main()
        {
            var startNum = int.Parse(Console.ReadLine());
            var lastNum = int.Parse(Console.ReadLine());

            if (Math.Abs(lastNum - startNum) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int first = startNum; first <= lastNum; first++)
                {
                    for (int second = first + 1; second <= lastNum; second++)
                    {
                        for (int third = second + 1; third <= lastNum; third++)
                        {
                            for (int fourth = third + 1; fourth <= lastNum; fourth++)
                            {
                                for (int fifth = fourth + 1; fifth <= lastNum; fifth++)
                                {
                                    if (first < second || second < third || third < fourth || fourth < fifth)
                                    {
                                        Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
