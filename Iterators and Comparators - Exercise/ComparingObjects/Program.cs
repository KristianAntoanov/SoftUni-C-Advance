namespace Stack
{
    using System;
    using ComparingObjects;

    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] personProps = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person()
                {
                    Name = personProps[0],
                    Age = int.Parse(personProps[1]),
                    Town = personProps[2]

                };
                people.Add(person);
            }
            int CompareIndex = int.Parse(Console.ReadLine()) - 1;
            Person PersonToCompare = people[CompareIndex];

            int equalCount = 0;
            int diffCount = 0;

            foreach (var currPerson in people)
            {
                if (currPerson.CompareTo(PersonToCompare) == 0)
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }
            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
            }
        }
    }
}