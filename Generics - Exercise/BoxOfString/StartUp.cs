namespace BoxOfString
{
    using System;

    internal class StartUp
    {
        public static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double item = double.Parse(Console.ReadLine());

                box.Add(item);
            }
            //int[] indices = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            //box.Swap(indices[0], indices[1]);
            double itemCompare = double.Parse(Console.ReadLine());


            Console.WriteLine(box.Count(itemCompare));
        }
    }
}