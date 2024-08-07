namespace BoxOfT
{
    using System;
    using GenericArrayCreator;

    internal class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", ArrayCreator.Create(50, "P")));

        }
    }
}