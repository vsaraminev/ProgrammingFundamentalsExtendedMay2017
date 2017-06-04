using System;

namespace Transport
{
    public class Transport
    {
        public static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = 24;

            int courses = persons / capacity;

            if (persons % capacity != 0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
