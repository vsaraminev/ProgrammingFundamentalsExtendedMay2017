﻿using System;

namespace DivisibleBy3
{
    public class DivisibleBy3
    {
        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
