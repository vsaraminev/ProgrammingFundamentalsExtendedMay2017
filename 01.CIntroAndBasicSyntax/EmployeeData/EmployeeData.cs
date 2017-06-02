using System;

namespace EmployeeData
{
    public class EmployeeData
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var ID = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {ID:d8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
