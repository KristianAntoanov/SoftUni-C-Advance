namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);

                Student student = new Student(name, age);
                students.Add(student);
            }
            string filterType = Console.ReadLine();
            int filterNumber = int.Parse(Console.ReadLine());

            Func<Student, int, bool> filter = FilterGenerator(filterType);

            students = students.Where(x => filter(x, filterNumber)).ToList();

            string format = Console.ReadLine();

            Action<Student> printer = PrinterGenerator(format);

            students.ForEach(x => printer(x));
        }
        static Action<Student> PrinterGenerator(string format)
        {
            if (format == "name age")
            {
                return s => Console.WriteLine($"{s.Name} - {s.Age}");
            }
            if (format == "name")
            {
                return s => Console.WriteLine($"{s.Name}");
            }
            if (format == "age")
            {
                return s => Console.WriteLine($"{s.Age}");
            }
            return null;
        }
        static Func<Student, int, bool> FilterGenerator(string filterType)
        {
            Func<Student, int, bool> filter = null;
            if (filterType == "older")
            {
                filter = (student, number) => student.Age >= number;
            }
            if (filterType == "younger")
            {
                filter = (student, number) => student.Age < number;
            }
            return filter;
        }
    }
    class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

    }
}
