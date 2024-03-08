namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] currStudent = Console.ReadLine()
                    .Split();
                string currName = currStudent[0];
                decimal currGrade = decimal.Parse(currStudent[1]);
                if (!grades.ContainsKey(currName))
                {
                    grades[currName] = new List<decimal>();
                }
                grades[currName].Add(currGrade);
            }

            foreach (var student in grades)
            {
                decimal currAverage = student.Value.Average();
                Console.Write($"{student.Key} -> ");
                for (int i = 0; i < student.Value.Count; i++)
                {
                    Console.Write($"{student.Value[i]:f2} ");
                }
                Console.WriteLine($"(avg: {currAverage:f2})");
            }
        }
    }
}
