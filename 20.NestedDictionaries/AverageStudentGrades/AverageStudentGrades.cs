using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    public class AverageStudentGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var currentStudent = Console.ReadLine().Split(' ');
                var name = currentStudent[0];
                var grade = double.Parse(currentStudent[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var student in grades)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value.Select(x => string.Format("{0:f2}",x)))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
