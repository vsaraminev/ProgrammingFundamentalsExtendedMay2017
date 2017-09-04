using System;
using System.Globalization;

namespace DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            var inputDate = Console.ReadLine();
            
            var date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);           
        }
    }
}
