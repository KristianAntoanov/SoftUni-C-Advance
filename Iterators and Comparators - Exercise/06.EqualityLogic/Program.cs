namespace EqualityLogic
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            HashSet<Person> hashSet = new();
            SortedSet<Person> sortedSet = new();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] personProps = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new(personProps[0], int.Parse(personProps[1]));

                hashSet.Add(person);
                sortedSet.Add(person);
            }
            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}