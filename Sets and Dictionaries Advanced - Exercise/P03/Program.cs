namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> chemicals = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] currChemical = Console.ReadLine()
                    .Split();
                for (int j = 0; j < currChemical.Length; j++)
                {
                    chemicals.Add(currChemical[j]);
                }
            }
            foreach (var item in chemicals.OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
        }
    }
}
