using System;

namespace BPMCounter
{
    public class BPMCounter
    {
        public static void Main()
        {
            var bpm = double.Parse(Console.ReadLine());
            var numberBeats = double.Parse(Console.ReadLine());
            var bars = Math.Round((numberBeats / 4), 1);

            var totalSeconds = 60 / bpm * numberBeats;

            var seconds = (int)totalSeconds % 60;
            var minutes = (int)totalSeconds / 60;

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
