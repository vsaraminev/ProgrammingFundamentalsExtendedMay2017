using System;

namespace X
{
    public class X
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var upLeftSide = 0;
            var upInsideSide = n - 2;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}",new string(' ',upLeftSide), new string(' ',upInsideSide));
                upLeftSide++;
                upInsideSide -= 2;
            }

            Console.WriteLine("{0}x{0}", new string(' ', upLeftSide));

            var downSide = (n - 3) / 2; ;
            var downInside = 1;            

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', downSide), new string(' ', downInside));
                downSide--;
                downInside += 2;
            }
        }
    }
}
