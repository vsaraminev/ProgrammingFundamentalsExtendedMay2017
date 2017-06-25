using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootListElements
{
    public class ShootListElements
    {
        public static void Main()
        {
            var command = Console.ReadLine();

            var result = new List<int>();

            var lastRemoved = 0;

            bool isBreak = false;

            while (command != "stop")
            {
                if (command != "bang")
                {
                    result.Insert(0, (int.Parse(command)));
                }
                else
                {                 

                    if (result.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemoved}");
                        isBreak = true;
                        break;
                    }
                    else
                    {
                        var average = result.Average();

                        for (int i = 0; i < result.Count; i++)
                        {
                            if (result[i] <= average)
                            {
                                lastRemoved = result[i];

                                Console.WriteLine($"shot {result[i]}");

                                result.Remove(result[i]);

                                

                                for (int j = 0; j < result.Count; j++)
                                {
                                    result[j]--;
                                }
                                break;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            if (result.Count > 0)
            {
                Console.WriteLine($"survivors: {string.Join(" ",result)}");
            }
            else if (result.Count == 0 && !isBreak)
            {
                Console.WriteLine($"you shot them all. last one was {lastRemoved}");
            }
        }
    }
}
